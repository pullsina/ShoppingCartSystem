using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartSystem
{
    internal class CartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        //Constructer
        public CartItem(Product product, int quantity)
        {
            this.Product = product;
            this.Quantity = quantity;
        }


        //Method 
        public decimal CalculateTotal()
        {
            return Quantity * Product.Price;
        }
    }
}
