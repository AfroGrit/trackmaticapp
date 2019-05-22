using System;

namespace TrackMaticApp
{
    public interface ITaxCalculator
    {
        float CalculateTax(Cart cart);
    }

    public class TaxCalculator : ITaxCalculator
    {
        public float CalculateTax(Cart cart)
        {

            switch (cart.Origin)
            {
                case "L":
                    {
                        cart.TotalPrice = cart.ItemPrice * 0.1f;
                        break;
                    }
                case "I":
                    {
                        cart.TotalPrice = cart.ItemPrice * 0.05f;
                        break;
                    }
                default:
                    {
                        cart.TotalPrice += cart.ItemPrice;
                        break;
                    }
            }



            Console.WriteLine("computed Tax on: {0} is {1}", cart.ItemPrice, cart.TotalPrice);
            // return cart.ItemPrice;
            return cart.TotalPrice;
        }   
    }
}   