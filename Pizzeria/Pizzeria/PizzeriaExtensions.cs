using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Pizzeria
{
    public static class PizzeriaExtensions
    {
        public static string GetIngredients(this Varietes variety, Ingredients items)
        {
            string ingredients;
            switch (variety)
            {
                case Varietes.Cheese:
                    ingredients =
                        $"Dough: {items.Dough}, Cheese: {items.Cheese}, Sauce: {items.Sauce}, Veggies: {string.Join(", ", items.Veggies)}";
                    break;
                case Varietes.Clam:
                    ingredients =
                        $"Dough: {items.Dough}, Clam: {items.Clam}, Sauce: {items.Sauce}, Cheese: {items.Cheese}";
                    break;
                case Varietes.Veggie:
                    ingredients =
                        $"Dough: {items.Dough}, Sauce: {items.Sauce}, Veggies: {string.Join(", ", items.Veggies)}";
                    break;
                default:
                    throw new ArgumentNullException(nameof(variety));
            }

            return ingredients;
        }
    }
}
