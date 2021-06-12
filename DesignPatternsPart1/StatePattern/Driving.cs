using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DesignPatternsPart1.StatePattern
{
    class Driving : IDirection
    {
        public object getDirection()
        {
            Console.WriteLine("Calculating ETA (driving)");
            return 1;
        }

        public object getEta()
        {
            Console.WriteLine("Calculating Direction (driving)");
            return 1;
        }
    }
}
