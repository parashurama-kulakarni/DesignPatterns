using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DesignPatternsPart1.IteratorPattern
{
    interface IIterator
    {
        bool hasNext();
        void Next();
        string Current();
    }
}
