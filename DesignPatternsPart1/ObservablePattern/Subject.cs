using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DesignPatternsPart1.ObservablePattern
{
    // Observable
    public class Subject
    {
        List<IObserver> observers = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify(string value)
        {
            foreach (IObserver observer in observers)
            {
                observer.update();
            }
        }
    }
}
