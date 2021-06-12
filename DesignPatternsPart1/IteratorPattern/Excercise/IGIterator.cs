using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DesignPatternsPart1.IteratorPattern.Excercise
{
    interface IGIterator<T>
    {
        bool hasNext();
        void Next();
        T Current();
    }
}
