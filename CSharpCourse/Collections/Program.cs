using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Laptop", "Acer Nitro 7");

            Console.WriteLine(dictionary["Laptop"]);


            Console.ReadKey();
        }
    }
}
