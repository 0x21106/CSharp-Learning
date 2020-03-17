using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{

    public delegate void MyDelegate();
    public delegate void MyDelegate2(string text);

    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();

            MyDelegate myDelegate = customerManager.SendMessage;
            MyDelegate2 myDelegate2 = customerManager.SendMessage2;

            //myDelegate();
            myDelegate2("Hi :)");
            //myDelegate += customerManager.ShowAlert;
            //myDelegate();


            Console.ReadKey();
        }

        public class CustomerManager
        {
            public void SendMessage()
            {
                Console.WriteLine("Hello!");
            }

            public void ShowAlert()
            {
                Console.WriteLine("Be Careful!");
            }
            public void SendMessage2(string msg)
            {
                Console.WriteLine(msg);
            }

            public void ShowAlert2(string msg)
            {
                Console.WriteLine(msg);
            }
        }
    }
}
