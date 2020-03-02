using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 20;
            int num2 = 100;
            var result = add(ref num1, num2);
            int num3;
            int num4;
            result = add2(out num3, out num4);
            //log(num1);
            //log(result);
            log("-----------------");
            log(add3(1,2,3,4,5,6,7,8,9,10));
            //Overloaded Function
            //log(add(1, 2, 3));


            //log("Hi World");
            //log(add(29, 1));
            //log(add());


            Console.ReadKey();
        }

        public static void log(object message)
        {
            Console.WriteLine(message);
        }

        static int add(ref int num1, int num2)
        {
            num1 = 30;
            return num1 + num2;
        }
        //Method Overloading
        static int add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
        static int add2(out int num3, out int num4)
        {
            num3 = 20;
            num4 = 10;
            return num3 + num4;
        }

        static int add3(params int[] numbers) {
            return numbers.Sum();
        }
    }
}
