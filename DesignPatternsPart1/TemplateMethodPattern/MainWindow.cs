using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DesignPatternsPart1.TemplateMethodPattern
{
    class MainWindow : Window
    {
       protected override void OnClosing()
        {
            Console.WriteLine("Cleaning before closing the window");
        }
    }
}
