using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Ausnahmebehandlung___2
{
    internal class YearOutOfRangeException : Exception
    {
        public YearOutOfRangeException(int jahr) : base($"Das Jahr {jahr} ist ungültig!")
        {
        }
    }
}
