using System;
using System.Collections.Generic;
using System.Text;

using PizzaFabric.TypePizza;

namespace PizzaFabric.Fabrics
{
    public class NY : PizzaStore
    {
        protected override Pizza createPizza(string type)
        {
            if (type == "cheese") return new NYCheesePizza();
            else return null;
        }
    }
}
