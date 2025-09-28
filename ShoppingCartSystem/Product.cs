using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartSystem
{
    internal class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        //Constructor
        public Product (string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
