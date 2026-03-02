using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Ausnahmebehandlung___2
{
    internal class DayOfMonthException : Exception
    {
        public DayOfMonthException() : base("Der Tag hat einen ungültigen Wert!")
        { }
    }
}
