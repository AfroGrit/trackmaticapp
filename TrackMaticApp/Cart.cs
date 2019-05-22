using System;

namespace TrackMaticApp
{
    public class Cart
    {
        // For dbs
        public int Id { get; set; }

        public string Item { get; set; }
        public string Origin { get; set; }

        public float ItemPrice { get; set; }


        public Tax Tax { get; set; }


        public float TotalPrice { get; set; }

        // TODO - change accept local or imported
        public bool IsTaxed
        {
            get { return Tax != null; }
        }
    }
}