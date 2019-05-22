using System;

namespace TrackMaticApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var cart = new Cart { Item = "Book", ItemPrice = 12.49f , Origin = "L"};

            Console.WriteLine("Inside a cart:" +
            	"\nID: {0} " +
            	"\nPrice: {1} " +
            	"\nOrigin: {2}", 
                cart.Item, cart.ItemPrice, cart.Origin);

            var cartEngine = new CartEngine(new TaxCalculator());

            cartEngine.TaxProcess(cart);
        }
    }
}
