using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        class Customer
        {
            protected int id { get; set; }

        }

        class Student : Customer
        {
            public int ChangeId(int new_id)
            {
                id = new_id;
                return id;
            }
        }

    }
}
