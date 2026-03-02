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
        public YearOutOfRangeException() : base("Das Jahr hat einen ungültigen Wert!")
        {
        }
    }
}
