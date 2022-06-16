using System;

using PizzaFabric.TypePizza;
using PizzaFabric.Fabrics;

namespace PizzaFabric
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore NYstore = new NY();
            PizzaStore CHIKAGOstore = new Chikago();

            Pizza pizza1 = NYstore.orderPizza("cheese");
            Console.WriteLine();
            Pizza pizza2 = CHIKAGOstore.orderPizza("cheese");
        }
    }
}
