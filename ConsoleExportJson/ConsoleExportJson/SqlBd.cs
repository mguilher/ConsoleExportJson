using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Data.SqlClient;

namespace ConsoleExportJson
{
    public class SqlBd
    {
        private const string _sqlTable = "select Name from sys.tables";
        private string _sqlfieldsbytable;
        private string _sqlRefTable;
        private string _sqlRefMeTable;

        public SqlBd()
        {
            var sb = new StringBuilder();
            sb.Append(" select sys.columns.name as [Name],")
                .Append(" sys.types.name as [Type],")
                .Append(" convert(varchar(10),sys.columns.max_length) as [MaxLength],")
                .Append(" convert(varchar(10),sys.columns.precision) as [Precision],")
                .Append(" convert(varchar(10),sys.columns.scale) as [Scale],")
                .Append(" sys.columns.is_nullable as [IsNullable],")
                .Append(" sys.columns.is_identity as [IsIdentity],")
                .Append(" (CASE WHEN isnull(sys.index_columns.column_id,0)>0 THEN 1 ELSE 0 END) as [IsPrimaryKey],")
                .Append(" (CASE WHEN isnull(sys.foreign_key_columns.parent_object_id,0)>0 THEN 1 ELSE 0 END) as [IsForeignKey]")
                .Append(" from sys.columns ")
                .Append(" inner join sys.types on (sys.types.user_type_id = sys.columns.user_type_id)")
                .Append(" left join sys.index_columns on (sys.index_columns.object_id=sys.columns.object_id ")
                .Append(" and sys.index_columns.column_id=sys.columns.column_id)")
                .Append(" left join sys.foreign_key_columns on (sys.foreign_key_columns.parent_object_id=sys.columns.object_id ")
                .Append(" and sys.foreign_key_columns.parent_column_id =sys.columns.column_id )")
                .Append(" where sys.columns.object_id =object_id(@P0) ")
                ;

            _sqlfieldsbytable = sb.ToString();

            sb.Clear();

            sb.Append("select K.name as[Key],")
                .Append(" sys.objects.name as[Table],")
                .Append(" C.name as[Column],")
                .Append(" CONS.name as [RefName]")
                .Append(" from sys.objects")
                .Append(" inner join sys.foreign_key_columns ")
                .Append(" on(sys.foreign_key_columns.parent_object_id=sys.objects.object_id)")
                .Append(" inner join sys.columns K on(K.object_id=sys.foreign_key_columns.referenced_object_id ")
                .Append(" and K.column_id=sys.foreign_key_columns.referenced_column_id)")
                .Append(" inner join sys.columns C on(C.object_id=sys.foreign_key_columns.parent_object_id ")
                .Append(" and C.column_id=sys.foreign_key_columns.parent_column_id)")
                .Append(" inner join sys.objects CONS on (CONS.object_id=sys.foreign_key_columns.constraint_object_id) ")
                .Append(" where sys.foreign_key_columns.referenced_object_id = object_id(@P0) ");

            _sqlRefMeTable = sb.ToString();

            sb.Clear();

            sb.Append("select  K.name as [Key],")
                .Append(" sys.objects.name as [Table], ")
                .Append(" C.name as [Column],")
                .Append(" CONS.name as [RefName]")
                .Append(" from sys.objects")
                .Append(" inner join sys.foreign_key_columns ")
                .Append(" on(sys.foreign_key_columns.referenced_object_id=sys.objects.object_id)")
                .Append(" inner join sys.columns K on(K.object_id=sys.foreign_key_columns.referenced_object_id ")
                .Append(" and K.column_id=sys.foreign_key_columns.referenced_column_id)")
                .Append(" inner join sys.columns C on(C.object_id=sys.foreign_key_columns.parent_object_id ")
                .Append(" and C.column_id=sys.foreign_key_columns.parent_column_id)")
                .Append(" inner join sys.objects CONS on (CONS.object_id=sys.foreign_key_columns.constraint_object_id) ")
                .Append(" where sys.foreign_key_columns.parent_object_id = object_id(@P0) ");

            _sqlRefTable = sb.ToString();

        }

        public Export GetExport(string sqlconnectionstring)
        {
            var result = new Export {Tables = GetTables(sqlconnectionstring)};

            foreach (var t in result.Tables)
            {
                t.Fields = GetFields(sqlconnectionstring, t.TableName);
                t.RefMeTables = GetRefMe(sqlconnectionstring, t.TableName);
                t.RefTables = GetRef(sqlconnectionstring, t.TableName);
            }

            return result;
        }

        private List<Table> GetTables(string sqlconnectionstring)
        {
            var result = new List<Table>();
            using (SqlConnection openCon = new SqlConnection(sqlconnectionstring))
            {
                openCon.Open();
                try
                {
                    using (SqlCommand cmd = openCon.CreateCommand())
                    {
                        cmd.CommandText = _sqlTable;
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            var obj = new Table
                            {
                                TableName = reader.GetString(0),
                            };
                            result.Add(obj);
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    string filename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                        "Erro_" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".txt");
                    File.WriteAllText(filename, ex.ToString());
                }
                finally
                {
                    openCon.Close();
                }
            }

            return result;
        }

        private List<Field> GetFields(string sqlconnectionstring, string id)
        {
            var result = new List<Field>();
            using (SqlConnection openCon = new SqlConnection(sqlconnectionstring))
            {
                openCon.Open();
                try
                {
                    using (SqlCommand cmd = openCon.CreateCommand())
                    {
                        cmd.CommandText = _sqlfieldsbytable;
                        cmd.Parameters.Add("@P0", SqlDbType.VarChar, 256).Value = id;
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            Field obj = new Field
                            {
                                IsForeignKey = Convert.ToBoolean(reader.GetValue(8)),
                                IsPrimaryKey = Convert.ToBoolean(reader.GetValue(7)),
                                IsIdentity = Convert.ToBoolean(reader.GetValue(6)),
                                IsNullable = Convert.ToBoolean(reader.GetValue(5)),
                                Scale = Convert.ToInt32(reader.GetString(4)),
                                Precision = Convert.ToInt32(reader.GetString(3)),
                                MaxLength = Convert.ToInt32(reader.GetString(2)),
                                Type = reader.GetString(1),
                                Name = reader.GetString(0)
                            };
                            result.Add(obj);
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    string filename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                        "Erro_" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".txt");
                    File.WriteAllText(filename, ex.ToString());
                }
                finally
                {
                    openCon.Close();
                }
            }

            return result;
        }

        private List<RefTable> GetRefMe(string sqlconnectionstring, string id)
        {
            var result = new List<RefTable>();
            using (SqlConnection openCon = new SqlConnection(sqlconnectionstring))
            {
                openCon.Open();
                try
                {
                    using (SqlCommand cmd = openCon.CreateCommand())
                    {
                        cmd.CommandText = _sqlRefMeTable;
                        cmd.Parameters.Add("@P0", SqlDbType.VarChar, 256).Value = id;
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            var obj = new RefTable
                            {
                                Key = reader.GetString(0),
                                Table = reader.GetString(1),
                                Column = reader.GetString(2),
                                RefName = reader.GetString(3),
                            };
                            result.Add(obj);
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    string filename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                        "Erro_" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".txt");
                    File.WriteAllText(filename, ex.ToString());
                }
                finally
                {
                    openCon.Close();
                }
            }

            return result;
        }

        private List<RefTable> GetRef(string sqlconnectionstring, string id)
        {
            var result = new List<RefTable>();
            using (SqlConnection openCon = new SqlConnection(sqlconnectionstring))
            {
                openCon.Open();
                try
                {
                    using (SqlCommand cmd = openCon.CreateCommand())
                    {
                        cmd.CommandText = _sqlRefTable;
                        cmd.Parameters.Add("@P0", SqlDbType.VarChar, 256).Value = id;
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            var obj = new RefTable
                            {
                                Key = reader.GetString(0),
                                Table = reader.GetString(1),
                                Column = reader.GetString(2),
                                RefName = reader.GetString(3),
                            };
                            result.Add(obj);
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    string filename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                        "Erro_" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".txt");
                    File.WriteAllText(filename, ex.ToString());
                }
                finally
                {
                    openCon.Close();
                }
            }

            return result;
        }
    }
}
