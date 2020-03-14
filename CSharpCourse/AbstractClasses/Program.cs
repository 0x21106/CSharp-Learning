﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        abstract class Database
        {
            public void Add()
            {
                Console.WriteLine("Added");
            }

            public abstract void Delete();
        }

        class Oracle : Database
        {
            public override void Delete()
            {
                Console.WriteLine("Deleted from oracle database");
            }
        }

    }
}
