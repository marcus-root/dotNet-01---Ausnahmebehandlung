using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Ausnahmebehandlung___1
{
    internal class Person
    {
        String _name;
        public String Name { get; set; }
        String _vorname;
        public String Vorname { get; set; }
        int _alter;
        public int Alter
        {
            get { return _alter; }
            set
            {
                if (value >= 0) _alter = value;
                else throw new Exception("Kein negatives Alter erlaubt!");
            }
        }
    }
}
