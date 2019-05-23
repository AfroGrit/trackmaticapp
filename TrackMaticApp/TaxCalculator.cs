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

            return 0;
        }   
    }
}   