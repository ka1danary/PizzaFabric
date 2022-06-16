using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PizzaFabric
{
    public abstract class Pizza
    {
        protected string name;
        protected string dought;
        protected string sause;
        

        public void prepare()
        {
            Console.Write("Preparing " + name);
            Thread.Sleep(100);
            Console.Write(".");
            Thread.Sleep(100);
            Console.Write(".");
            Thread.Sleep(100);
            Console.Write(".");
            Thread.Sleep(100);
            Console.WriteLine();
        }

        public void bake()
        {
            Console.Write("Bake " + name);
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.WriteLine();
        }

        public void cut()
        {
            Console.Write("Cut " + name);
            Thread.Sleep(100);
            Console.Write(".");
            Thread.Sleep(100);
            Console.Write(".");
            Thread.Sleep(100);
            Console.Write(".");
            Thread.Sleep(100);
            Console.WriteLine();
        }

        public void box()
        {
            Console.Write("Box " + name);
            Thread.Sleep(100);
            Console.Write(".");
            Thread.Sleep(100);
            Console.Write(".");
            Thread.Sleep(100);
            Console.Write(".");
            Thread.Sleep(100);
            Console.WriteLine();
        }

        public string getName()
        {
            return name;
        }
    }
}
