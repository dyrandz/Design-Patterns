using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    public class PizzeriaBFactory : PizzeriaFactory
    {
        public override IPizzeria Create() => new PizzeriaB();
    }
}
