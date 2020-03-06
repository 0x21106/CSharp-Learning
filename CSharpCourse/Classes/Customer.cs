using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Customer
    {
        public int id { get; set; }

        private string __firstName;
        public string firstName {
            get
            {
                return "Mr. " + __firstName;
            } 
            set
            {
                __firstName = value;
            } 
        }
        public string lastName { get; set; }
        public string city { get; set; }
    }
}
