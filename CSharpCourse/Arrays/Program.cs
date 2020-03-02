using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array definition type one
            //string[] students = new string[3];
            //students[0] = "Ayxan";
            //students[1] = "Ayten";
            //students[2] = "Aytac";

            //Array definition type two
            //string[] students2 = { "Ayxan", "Ayten", "Aytac" };
            
            //foreach(var student in students2)
            //{
            //    Console.WriteLine(student);
            //}

            string[,] sehirler = new string[5, 3] {
                { "İstanbul", "İzmit", "Balıkesir" },
                { "Ankara", "Konya", "Kırıkkale" },
                { "Antalya", "Adana", "Mersin" },
                { "Rize", "Trabzon", "Samsun" },
                { "İzmir", "Muğla", "Manisa" }
            };

            for(int a = 0; a <= sehirler.GetUpperBound(0); a++)
            {
                if(a == 0) {
                    Console.WriteLine("-----------");
                }
                for (int b = 0; b <= sehirler.GetUpperBound(1); b++)
                {
                    Console.WriteLine(sehirler[a, b]);
                }
                Console.WriteLine("-----------");
            }

            Console.ReadLine();

        }
    }
}
