using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DesignPatternsPart1.ObservablePattern
{
    public class Chat : IObserver
    {
        private DataSource dataSource;

        public Chat(DataSource dataSource)
        {
            this.dataSource = dataSource;
        }

        public void update()
        {
            Console.WriteLine("Chat updated:" + dataSource.GetValue());
        }
    }
}
