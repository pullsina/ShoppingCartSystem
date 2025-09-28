using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartSystem
{
    internal class ShoppingCart
    {
        public List<CartItem> Items { get; set; }


        //Constructer 
        public ShoppingCart()
        {
            Items = new List<CartItem>();
        }
        //Methods
        public void AddProduct(Product product, int qty)
        {
            CartItem existingItem = null;
            foreach (CartItem item in Items)
            {
                if (item.Product.Name == product.Name)
                {
                    existingItem = item;
                    break;
                }
            }
            if (existingItem != null)
            {
                existingItem.Quantity += qty;
            }
            else
                Items.Add(new CartItem(product, qty));
        }

        public void RemoveProduct(Product product)
        {
            CartItem productToRemove = null;
            foreach (CartItem item in Items)
            {
                if (item.Product.Name == product.Name)
                {
                    productToRemove = item;
                    break;
                }
            }
            if (productToRemove != null)
            {
                Items.Remove(productToRemove);
                Console.WriteLine($"{product.Name} was removed from the cart.");
            }
            else
                Console.WriteLine($"No product with name {product.Name} was found");
        }

        public decimal GetTotal()
        {
            decimal total = 0;
            foreach (CartItem item in Items)
            {
                total += item.CalculateTotal();
            }
            Console.WriteLine($"The total price is {total}");
            return total;
        }

        public void DisplayCart ()
        {
            Console.WriteLine("The products in the cart:");
            foreach (CartItem item in Items)
            {
                Console.WriteLine($"{item.Product.Name} - {item.Quantity}");
            }
            GetTotal();
        }
    }
}
