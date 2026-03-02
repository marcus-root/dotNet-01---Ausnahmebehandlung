using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions___02___Bahnhöfe__amp__Züge
{
    internal class RailwayStationException : Exception
    {
        public RailwayStationException(String message) : base(message)
        { }
    }
}
