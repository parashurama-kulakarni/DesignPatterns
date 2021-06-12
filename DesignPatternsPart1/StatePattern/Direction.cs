using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DesignPatternsPart1.StatePattern
{
    class Direction
    {
        private IDirection direction;

        public Direction(IDirection direction)
        {
            this.direction = direction;
        }

        public object getDirection()
        {
            return direction.getDirection();
        }

        public object getEta()
        {
            return direction.getEta();
        }
    }
}
