using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    public abstract class PizzeriaFactory
    {
        public abstract IPizzeria Create();
    }
}
