using System;
using System.Collections.Generic;

namespace TrackMaticApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var ShoppingList = new List<Cart>()

            {
                new Cart(Type.Local, "Book", 12.49),
                new Cart(Type.Local, "Music CD", 14.99),
                new Cart(Type.Local, "Chocolate", 0.85)
            };

            Console.WriteLine(" Output");
            for (int i = 0; i < ShoppingList.Count; ++i)
            {
                Console.WriteLine("id: {0} {1}: {2:C} ", i, ShoppingList[i].Name, ShoppingList[i].Amount);
            }
        }
    }
}
