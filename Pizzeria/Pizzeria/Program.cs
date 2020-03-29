using System;

namespace Pizzeria
{
    class Program
    {
        static void Main(string[] args)
        {
            var pizzeriaA = new Pizzeria().ExecuteCreation(Pizzerias.PizzeriaA);
            pizzeriaA.Order(Varietes.Cheese);
            pizzeriaA.Order(Varietes.Clam);
            pizzeriaA.Order(Varietes.Veggie);

            Console.WriteLine();

            var pizzeriaB = new Pizzeria().ExecuteCreation(Pizzerias.PizzeriaB);
            pizzeriaB.Order(Varietes.Cheese);
            pizzeriaB.Order(Varietes.Clam);
            pizzeriaB.Order(Varietes.Veggie);
        }
    }
}
