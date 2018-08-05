using System;
using System.Data.SqlClient;
using System.IO;

namespace ConsoleExportJson
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ConsoleKeyInfo key;
                string sqlconnectionstring = "";
                if (args.Length > 0)
                {
                    sqlconnectionstring = args[0];
                }
                else
                {
                    #region Get sql connection string
                    do
                    {
                        Console.WriteLine("Type Y[Yes] for full string or N[No] for build a connection E[Exit] for leave ");
                        key = Console.ReadKey();
                    } while (key.Key != ConsoleKey.Y && key.Key != ConsoleKey.N && key.Key != ConsoleKey.E);

                    Console.WriteLine();

                    if (key.Key == ConsoleKey.E)
                    {
                        return;
                    }

                    if (key.Key == ConsoleKey.Y)
                    {
                        Console.WriteLine("Type a Connection String");
                        sqlconnectionstring = Console.ReadLine();
                    }
                    else
                    {
                        var scb = new SqlConnectionStringBuilder();
                        Console.WriteLine("Type server name");
                        scb.DataSource = Console.ReadLine();
                        Console.WriteLine("Type database name");
                        scb.InitialCatalog = Console.ReadLine();

                        ConsoleKeyInfo skey;
                        do
                        {
                            Console.WriteLine("Integrated Security Y[Yes] N[No]");
                            skey = Console.ReadKey();
                        } while (skey.Key != ConsoleKey.Y && skey.Key != ConsoleKey.N);

                        if (skey.Key == ConsoleKey.Y)
                        {
                            scb.IntegratedSecurity = true;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Enter a user ");
                            scb.UserID = Console.ReadLine();

                            Console.WriteLine("Enter a password ");
                            scb.Password = Console.ReadLine();
                        }

                        sqlconnectionstring = scb.ConnectionString;
                    }
                    #endregion
                }

                var bd = new SqlBd();
                Export export = bd.GetExport(sqlconnectionstring);
                var json = Newtonsoft.Json.JsonConvert.SerializeObject(export);
                string filename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                           "json_" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".json");
                File.WriteAllText(filename, json);

                Console.WriteLine("JOSN data in file '{0}'", filename);

                Console.WriteLine("");
                Console.WriteLine("Try open?  Y[Yes] or N[No] ");
                key = Console.ReadKey();

                if (key.Key == ConsoleKey.Y)
                {
                    System.Diagnostics.ProcessStartInfo procStart =new System.Diagnostics.ProcessStartInfo("notepad.exe", filename);
                    System.Diagnostics.Process.Start(procStart);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();
            Console.WriteLine("Press any key for leave");
            Console.ReadKey();
        }
    }
}
