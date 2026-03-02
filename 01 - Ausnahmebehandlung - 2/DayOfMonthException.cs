using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Ausnahmebehandlung___2
{
    internal class DayOfMonthException : Exception
    {
        public DayOfMonthException(int tag) : base($"Der Tag {tag} ist ungültig!")
        { }
    }
}
