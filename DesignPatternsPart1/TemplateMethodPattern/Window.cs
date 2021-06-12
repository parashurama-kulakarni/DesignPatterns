using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DesignPatternsPart1.TemplateMethodPattern
{
    public abstract class Window
    {
        public void Close()
        {
            OnClosing();

            Console.WriteLine("Removing the window from the screen");

            AfterClosing();
        }

        protected virtual void OnClosing() { }
        protected virtual void AfterClosing(){}

    }
}
