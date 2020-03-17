using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //ActionDemo();

            Func<int> GetRandom = delegate()
            {
                Random random = new Random();
                return random.Next(1, 100);
            };

            GetRandom();

            Thread.Sleep(1000);

            Func<int> GetRandom2 = () => new Random().Next(1, 100);

            Console.WriteLine(GetRandom());


            Console.ReadKey();
        }

        private static void ActionDemo()
        {
            HandleException(() => { Find(); });
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
