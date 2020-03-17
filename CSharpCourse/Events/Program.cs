using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Product KingstonHardDisk = new Product(50);
            KingstonHardDisk.ProductName = "Kingston Hard Disk";

            Product IPhoneXS = new Product(50);
            IPhoneXS.ProductName = "IPhone XS Max";
            IPhoneXS.StockControlEvent += IPhoneXS_StockControlEvent;

            for (int i = 0; i < 10; i++)
            {
                KingstonHardDisk.Sell(10);
                IPhoneXS.Sell(10);
                Console.ReadKey();
            }


            Console.ReadKey();
        }

        private static void IPhoneXS_StockControlEvent()
        {
            Console.WriteLine("Iphone about to finish!");
        }
    }
}
