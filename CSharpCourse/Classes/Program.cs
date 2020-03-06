using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.city = "Baku";
            customer.id = 1;
            customer.firstName = "Ayxan";
            customer.lastName = "Abdullayev";

            Customer customer2 = new Customer
            {
                id = 2,
                city = "Gence",
                firstName = "Tuziq",
                lastName = "Paltaryuyan"
            };

            //Console.WriteLine(customer.firstName);
            Console.WriteLine(customer2.firstName);

            Console.ReadKey();
        }
    }
}
