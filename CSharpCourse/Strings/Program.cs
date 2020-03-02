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
            string msg = "My name is Ayxan.";
            var msg2 = msg.Clone();
            var msg3 = msg;

            msg = "My name is Santa Barbara";

            bool endsWith = msg.EndsWith("bara");
            bool startsWith = msg.StartsWith("M");

            var index = msg.IndexOf("a");
            var lastIndex = msg.LastIndexOf("a");

            var res = msg.Insert(0, "Hello, ");
            var res2 = msg.Substring(3, 4);
            var res3 = msg.ToLower();
            var res4 = msg.ToUpper();
            var res5 = msg.Replace(" ", "*");
            var res6 = msg.Remove(2, 15);

            log(res6);
            //log(res5);
            //log(res3);
            //log(res4);
            //log(res2);
            //log(res);
            //log(index);
            //log(lastIndex);

            //log(String.Format("is msg starts with: bara?  -  {0}", startsWith));
            //log(String.Format("is msg ends with: M?  -  {0}", endsWith));

            //log(msg.Length);
            //log(msg);
            //log(msg2);
            //log(msg3);


            Console.ReadKey();
        }

        static void test()
        {
            string[] city = { "Baku", "Istanbul" };
            //Console.WriteLine(city[0][0]);


            foreach (var __char in city[0])
            {
                Console.WriteLine(__char);
            }

            log(String.Format("{0} {1}", city[0], city[1]));
            Console.WriteLine("{0} {1}", city[0], city[1]);
        }

        static void log(object msg)
        {
            Console.WriteLine(msg);
        }

    }
}
