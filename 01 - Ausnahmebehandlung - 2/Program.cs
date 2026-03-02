using System;

namespace _01___Ausnahmebehandlung___2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleDate datum = new SimpleDate();

            Console.WriteLine("Zuweisung eines ungültigen Datums:");
            try
            {
                try { datum.Year = 2027; }
                catch (Exception a) { Console.WriteLine(a.Message); throw; }
                try { datum.Month = 2; }
                catch (Exception b) { Console.WriteLine(b.Message); throw; }
                try { datum.Day = 29; }
                catch (Exception c) { Console.WriteLine(c.Message); throw; }
            }
            catch (Exception e) { Console.WriteLine("Datum Fehlerhaft, Zuweisung abgebrochen"); }
            finally { Console.WriteLine("try-catch zu ende\n"); }

            Console.WriteLine("gültiges Datum:");
            try
            {
                datum.Year = 2028; //2028 ist ein Schaltjahr
                datum.Month = 2;
                datum.Day = 29;
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            finally { Console.WriteLine("try-catch zu ende"); }
        }
    }
}
