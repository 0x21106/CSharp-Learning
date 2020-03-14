using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager manager = new CustomerManager();
            manager.logger = new DatabaseLogger();
            manager.Add();


            Console.ReadKey();
        }

        class CustomerManager
        {
            public ILogger logger { get; set; }
            public void Add()
            {
                logger.Log();
                Console.WriteLine("Customer Added :)");

            }
        }

        interface ILogger
        {
            void Log();
        }

        class DatabaseLogger : ILogger
        {
            public void Log()
            {
                Console.WriteLine("Logged to database!");
            }
        }

    }
}
