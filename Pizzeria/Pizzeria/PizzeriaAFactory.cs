using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    public class PizzeriaAFactory : PizzeriaFactory
    {
        public override IPizzeria Create() => new PizzeriaA();
    }
}
