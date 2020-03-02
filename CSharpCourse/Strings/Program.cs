using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] city = { "Baku", "Istanbul" };
            //Console.WriteLine(city[0][0]);


            foreach(var __char in city[0]) {
                Console.WriteLine(__char);
            }

            Console.WriteLine(String.Format("{0} {1}", city[0], city[1]));
            Console.WriteLine("{0} {1}", city[0], city[1]);


            Console.ReadKey();
        }
    }
}
