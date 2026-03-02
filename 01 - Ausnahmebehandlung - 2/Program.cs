using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Ausnahmebehandlung___2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleDate datum = new SimpleDate();

            datum.Year = 2026; // 2026 ist kein Schaltjahr
            datum.Month = 2;
            datum.Day = 29;

            datum.Year = 2028; //2028 ist ein Schaltjahr
            datum.Month = 2;
            datum.Day = 29;

            Console.WriteLine("Keine Fehler.");

        }
    }
}
