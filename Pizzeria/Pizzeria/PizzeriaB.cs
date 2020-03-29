using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    public class PizzeriaB : IPizzeria
    {
        private static Ingredients _ingredients;

        public void Order(Varietes variety)
        {
            _ingredients = new Ingredients
            {
                Cheese = "Parmesan",
                Clam = "Fresh Clam",
                Dough = "Deep Dish",
                Sauce = "Plum Tomato",
                Veggies = new[] { "Cucumber", "Onions", "Pepper" }
            };
            Prepare(variety);
            Bake();
            Cut();
            Box();
            Console.WriteLine();
        }

        private static void Prepare(Varietes variety)
        {
            Console.WriteLine($"Preparing Pizzeria B Style {variety} Using");
            Console.WriteLine(((Varietes)variety).GetIngredients(_ingredients));
        }

        private static void Bake()
        {
            Console.WriteLine("Baking at 135 degree Celsius for 25 minutes");
        }

        private static void Cut()
        {
            Console.WriteLine("Cutting into diagonal pieces");
        }

        private static void Box()
        {
            Console.WriteLine("Putting pizza in Green coloured box");
        }
    }
}
