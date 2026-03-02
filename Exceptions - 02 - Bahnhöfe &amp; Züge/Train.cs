using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions___02___Bahnhöfe__amp__Züge
{
    internal class Train
    {
        public String Zugnummer { get; }
        public int Wagons { get; }

        public Train(string zugnummer, int wagons)
        {
            Zugnummer = zugnummer;
            Wagons = wagons;
        }

        public override string ToString()
        {
            String wagon = "[   ]";
            String wagons = "";
            for(int i=0; i<Wagons; i++)
            {
                wagons += wagon + " - ";
            }
            return $"{wagons}";
        }
    }
}
