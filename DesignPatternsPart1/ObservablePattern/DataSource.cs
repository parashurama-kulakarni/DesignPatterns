using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DesignPatternsPart1.ObservablePattern
{
    public class DataSource : Subject
    {
        private string value;

        public void SetValue(string data)
        {
            value = data;
            Notify(value);
        }

        public string GetValue()
        {
            return value;
        }
    }
}
