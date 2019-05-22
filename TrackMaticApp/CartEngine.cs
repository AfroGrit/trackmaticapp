using System;

namespace TrackMaticApp
{
    public class CartEngine
    {
        private readonly ITaxCalculator _taxCalculator;

        public CartEngine(ITaxCalculator taxCalculator)
        {
            _taxCalculator = new TaxCalculator();
        }

        public void TaxProcess(Cart cart)
        {
            if (cart.IsTaxed)
                throw new System.InvalidOperationException("Already taxed");

            cart.Tax = new Tax
            {
                TaxCost = _taxCalculator.CalculateTax(cart),
            };
        }

    }
}