using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DesignPatternsPart1.StatePattern
{
    class BiCycling : IDirection
    {
        public object getDirection()
        {
            Console.WriteLine("Calculating ETA (bicycling)");
            return 2;
        }

        public object getEta()
        {
            Console.WriteLine("Calculating Direction (bicycling)");
            return 2;
        }
    }
}
