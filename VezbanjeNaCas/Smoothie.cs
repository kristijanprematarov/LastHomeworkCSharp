using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace VezbanjeNaCas
{
    public class Smoothie : ISmoothie
    {
        private Dictionary<string[], double> _ingredients;

        public Dictionary<string[], double> Ingredients
        {
            get { return _ingredients; }
            set { _ingredients = value; }
        }

        public Smoothie(Dictionary<string[], double> theIngredients)
        {
            this._ingredients = theIngredients;
        }

        public double GetCost()
        {
            double Price = _ingredients.Values.Sum();
            return Price;
        }

        public void GetPrice()
        {
            double totalPrice = this.GetCost() + this.GetCost() * 1.5;
            Console.WriteLine("\n");
            Console.WriteLine("The total price is: {0}", totalPrice.ToString("C2", CultureInfo.GetCultureInfo("en-US")));
        }

        public void GetName()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Your smoothie is:");
            foreach (var item in _ingredients)
            {
                foreach (string ingredient in item.Key)
                    Console.Write(ingredient + " ");

                if (item.Key.Length == 1)
                    Console.Write("Smoothie");
                else
                    Console.Write("Fusion");


            }
        }

    }
}
