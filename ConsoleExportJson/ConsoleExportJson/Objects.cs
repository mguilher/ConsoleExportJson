using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleExportJson
{
    public class Export
    {
        public List<Table> Tables { get; set; }
    }

    public class Table
    {
        public string TableName { get; set; }
        public List<Field> Fields { get; set; }
        public List<RefTable> RefMeTables { get; set; }
        public List<RefTable> RefTables { get; set; }

    }

    public class Field
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int MaxLength { get; set; }
        public int Precision { get; set; }
        public int Scale { get; set; }
        public bool IsNullable { get; set; }
        public bool IsIdentity { get; set; }
        public bool IsPrimaryKey { get; set; }
        public bool IsForeignKey { get; set; }
        public int Id { get; set; }
    }

    public class RefTable
    {
        public string Key { get; set; }
        public string Table { get; set; }
        public string Column { get; set; }
        public string RefName { get; set; }
    }
}
