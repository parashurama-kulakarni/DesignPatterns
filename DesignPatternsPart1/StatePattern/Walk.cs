using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DesignPatternsPart1.StatePattern
{
    class Walk : IDirection
    {
        public object getDirection()
        {
            Console.WriteLine("Calculating ETA (bicycling)");
            return 4;
        }

        public object getEta()
        {
            Console.WriteLine("Calculating ETA (bicycling)");
            return 4;
        }
    }
}
