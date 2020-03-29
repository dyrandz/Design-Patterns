using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    public class Pizzeria
    {
        private readonly Dictionary<Pizzerias, PizzeriaFactory> _factories;

        public Pizzeria()
        {
            _factories = new Dictionary<Pizzerias, PizzeriaFactory>
            {
                { Pizzerias.PizzeriaA, new PizzeriaAFactory() },
                { Pizzerias.PizzeriaB, new PizzeriaBFactory() }
            };
        }

        public IPizzeria ExecuteCreation(Pizzerias pizzeria) => _factories[pizzeria].Create();
    }
}
