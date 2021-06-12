using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DesignPatternsPart1.ObservablePattern
{
    public class SpreadSheet : IObserver
    {
        private DataSource dataSource;

        public SpreadSheet(DataSource dataSource)
        {
            this.dataSource = dataSource;
        }

        public void update()
        {
            Console.WriteLine("Spread Sheet notified: " + dataSource.GetValue());
        }
    }
}
