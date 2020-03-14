using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //interfacesIntro();

            CustomerManager manager = new CustomerManager();

            manager.Add(new SqlServerCustomerDal());

            Console.ReadKey();
        }

        private static void interfacesIntro()
        {
            PersonManager manager = new PersonManager();
            IPerson[] persons =
            {
                new Customer
                {
                    Id = 1,
                    FirstName = "Ayxan",
                    LastName = "Abdullayev"
                },
                new Student
                {
                    Id = 1,
                    FirstName = "Ayxan",
                    LastName = "Abdullayev"
                }
            };
            manager.Add(persons[1]);
            Console.ReadKey();
        }

        interface IPerson
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }

        }

        class Customer : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        class Student:IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}
