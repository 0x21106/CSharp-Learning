using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Database[] databases =
           {
                new SqlServer(),
                new MySqlServer()
            };

            foreach (var database in databases)
            {
                database.Add();
                database.Delete();
            }

            Console.ReadKey();

        }

        class Database
        {
            public virtual void Add()
            {
                Console.WriteLine("Added by default");
            }

            public virtual void Delete()
            {
                Console.WriteLine("Added by default");
            }
        }

        class SqlServer : Database
        {
            public override void Add()
            {
                Console.WriteLine("Added by SQL");
                //base.Add();
            }

        }

        class MySqlServer : Database
        {
            public override void Delete()
            {
                Console.WriteLine("Added by MySql");
                //base.Delete();
            }
        }

    }
}
