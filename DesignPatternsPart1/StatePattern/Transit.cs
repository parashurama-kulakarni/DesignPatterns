using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DesignPatternsPart1.StatePattern
{
    class Transit : IDirection
    {
        public object getDirection()
        {
            Console.WriteLine("Calculating ETA (bicycling)");
            return 3;
        }

        public object getEta()
        {
            Console.WriteLine("Calculating Direction (bicycling)");
            return 3;
        }
    }
}
