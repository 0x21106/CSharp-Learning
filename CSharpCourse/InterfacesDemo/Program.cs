using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers =
            {
                new Manager(),
                new Worker(),
                new Robot()
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats =
            {
                new Manager(),
                new Worker()
            };

            foreach (var eat in eats)
            {
                eat.Eat();
            }

            Console.ReadKey();

        }

        interface IWorker
        {
            void Work();
        }

        interface IEat
        {
            void Eat();
        }

        interface IGetSalary
        {
            void getSalary();
        }

        class Manager : IWorker, IEat, IGetSalary
        {
            public void Eat()
            {
                Console.WriteLine("Manager Eated");
            }

            public void getSalary()
            {
                throw new NotImplementedException();
            }

            public void Work()
            {
                Console.WriteLine("Manager working");
            }
        }

        class Worker : IWorker, IEat, IGetSalary
        {
            public void Eat()
            {
                Console.WriteLine("Worker Eated");
            }

            public void getSalary()
            {
                throw new NotImplementedException();
            }

            public void Work()
            {
                Console.WriteLine("Worker working");
            }
        }

        class Robot : IWorker
        {
            public void Work()
            {
                Console.WriteLine("Robot Working");
            }
        }

    }
}
