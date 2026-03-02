using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Ausnahmebehandlung___2
{
    internal class MonthOutOfRangeException : Exception
    {
        public MonthOutOfRangeException() : base("Der Monat hat einen ungültigen Wert!")
        {
        }
    }
}
