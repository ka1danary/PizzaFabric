using System;
using System.Collections.Generic;
using System.Text;

using PizzaFabric.TypePizza;

namespace PizzaFabric.Fabrics
{
    public class Chikago : PizzaStore
    {
        protected override Pizza createPizza(string type)
        {

            if (type == "cheese") return new ChikagoCheesePizza();
            else return null;
        }
    }
}
