using System;

namespace TrackMaticApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var cartEngine = new CartEngine(new TaxCalculator());

            var cart = new Cart { Item = "Book", ItemPrice = 12.49f , Origin = "L"};

            // var cart_2 = new Cart { Item = "Music CD", ItemPrice = 14.99f, Origin = "L" };
            // var cart_2 = new Cart { Item = "Book", ItemPrice = 12.49f, Origin = "L" };

            cartEngine.TaxProcess(cart);
        }
    }
}
