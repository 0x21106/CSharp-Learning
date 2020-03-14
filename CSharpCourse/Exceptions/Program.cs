using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            HandleException(() =>
            {
                Find();
            });


            Console.ReadKey();
        }
        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            List<string> cities = new List<string>
            {
                "Baku",
                "Ankara",
                "Moscow"
            };
            if (!cities.Contains("Berlin"))
            {
                throw new EntryPointNotFoundException();
            }
        }


    }
}
