using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesNVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = 10.8;
            decimal price2 = 10.22313123m;
            char character = 'A';
            bool isTrue = false;
            byte number4 = 255;
            short number3 = 32767;
            int number = 2147483647;
            long number2 = 922337203685477807;
            Console.WriteLine("Number 1 is {0}", number);
            Console.WriteLine("Number 2 is {0}", number2);
            Console.WriteLine("Number 3 is {0}", number3);
            Console.WriteLine("Number 4 is {0}", number4);
            Console.WriteLine("Character is {0}", character);
            Console.WriteLine("Price is {0}", price);
            Console.WriteLine("Today is {0}", Days.Monday);
            Console.ReadLine();
        }
    }
    enum Days {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
}
