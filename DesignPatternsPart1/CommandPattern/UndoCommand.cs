using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DesignPatternsPart1.CommandPattern
{
    public interface UndoCommand : ICommand
    {
        void Undo();
    }
}
