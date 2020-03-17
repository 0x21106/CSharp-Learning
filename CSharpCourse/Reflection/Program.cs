using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //DortIslem di = new DortIslem(5, 10);

            //var result = di.Topla(3,2);

            //Console.WriteLine(result);
            
            var tip = typeof(DortIslem);

            var instance = Activator.CreateInstance(tip, 6, 3);

            Console.WriteLine(instance.GetType().GetMethod("Topla2").Invoke(instance, null));


            //Console.WriteLine(di.Topla());

            Console.ReadKey();
        }

        public class DortIslem
        {
            private int _sayi1;
            private int _sayi2;

            public DortIslem(int sayi1, int sayi2)
            {
                this._sayi1 = sayi1;
                this._sayi2 = sayi2;
            }

            public DortIslem()
            {
                
            }

            public int Topla()
            {
                return this._sayi1 + this._sayi2;
            }
            public int Topla2()
            {
                return this._sayi1 + this._sayi2;
            }
            public int Carp()
            {
                return this._sayi1 * this._sayi2;
            }
            public int Topla(int num1, int num2)
            {
                return num1 + num2;
            }
            public int Carp(int num1, int num2)
            {
                return num1 * num2;
            }
        }
    }
}
