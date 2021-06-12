using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DesignPatternsPart1.StatePattern
{
    class Airline : IDirection
    {
        public object getDirection()
        {
            Console.WriteLine("Calculating ETA (Air)");
            return 5;
        }

        public object getEta()
        {
            Console.WriteLine("Calculating Direction (Air)");
            return 5;
        }
    }
}
