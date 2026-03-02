using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace _01___Ausnahmebehandlung___1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person erlaubt = new Person();
            erlaubt.Alter = 30;

            Person verboten = new Person();
            verboten.Alter = -1;
        }
    }
}
