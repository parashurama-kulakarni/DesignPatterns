using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DesignPatterns.DesignPatternsPart1.IteratorPattern
{
    class BrowserHistory
    {
        //private List<string> Urls = new List<string>();
        
        private string[] Urls = new string[4];
        private int count;

        public void Push(string url)
        {
            //Urls.Add(url);
            Urls[count++] = url;
        }

        public string Pop()
        {
            //var lastIndex = Urls.Count() -1;
            //var url = Urls[lastIndex];
            //Urls.RemoveAt(lastIndex);

            return Urls[--count];
        }

        //public IIterator CreateIterator() => new ListIterator(this);
        public IIterator CreateIterator() => new ArrayIterator(this);

        public class ArrayIterator : IIterator
        {
            private int index;

            public ArrayIterator(BrowserHistory history)
            {
                this.history = history;
            }

            public BrowserHistory history { get; }

            public string Current() => history.Urls[index];

            public bool hasNext() => index < history.Urls.Length;

            public void Next() => index++;
        }

        //public class ListIterator : IIterator
        //{
        //    private BrowserHistory history;

        //    public ListIterator(BrowserHistory history)
        //    {
        //        this.history = history;
        //    }

        //    public int index;

        //    public string Current() => history.Urls[index];

        //    public bool hasNext() => index < history.Urls.Count;

        //    public void Next() => index++;

        //}
    }
}
