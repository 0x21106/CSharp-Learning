using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 3;
            if(isPrimeNumber(num))
            {
                Console.WriteLine("This is a prime number: {0}", num);
            } 
            else
            {
                Console.WriteLine("This is not a prime number: {0}", num);
            }
            Console.ReadKey();
        }

        private static bool isPrimeNumber(int number)
        {
            bool result = true;
            for(int i = 2; i < number - 1; i++)
            {
                if((number % i) == 0)
                {
                    result = false;
                }
            }
            return result;
        }

    }
}
