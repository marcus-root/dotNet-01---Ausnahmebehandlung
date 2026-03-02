using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Ausnahmebehandlung___2
{
    internal class MonthOutOfRangeException : Exception
    {
        public MonthOutOfRangeException(int monat) : base($"Der Monat {monat} ist ungültig!")
        {
        }
    }
}
