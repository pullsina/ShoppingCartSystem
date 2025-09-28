namespace ShoppingCartSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Apple", 30);
            Product product2 = new Product("Banana", 50);
            Product product3 = new Product("Honey", 60);
            Product product4 = new Product("Tea", 10);
            ShoppingCart shoppingCart = new ShoppingCart();
            shoppingCart.AddProduct(product1, 2);
            shoppingCart.AddProduct(product2, 3);
            shoppingCart.AddProduct(product3, 1);
            shoppingCart.DisplayCart();
            shoppingCart.RemoveProduct(product1);
            shoppingCart.DisplayCart();
            shoppingCart.RemoveProduct(product4);

        }
    }
}
