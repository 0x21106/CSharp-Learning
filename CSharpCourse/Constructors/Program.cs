using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Customer customer = new Customer(10);

            //customer.Add();
            PersonManager manager = new PersonManager("Product");

            Console.ReadKey();

        }

        class Customer
        {
            int count = 0;

            public Customer()
            {

            }
            public Customer(int count)
            {
                this.count = count;
            }
            public void Add()
            {
                Console.WriteLine("Added {0 } items", count);
            }
        }

        class BaseClass
        {
            private string _entity;
            public BaseClass(string entity)
            {
                _entity = entity;
            }
            public void Message()
            {
                Console.WriteLine("{0} message", _entity);
            }
        }

        class PersonManager : BaseClass
        {
            public PersonManager(string entity) : base(entity)
            {
                Message();
            }
        }

    }
}
