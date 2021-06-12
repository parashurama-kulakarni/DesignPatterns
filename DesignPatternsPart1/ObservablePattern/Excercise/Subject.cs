using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DesignPatternsPart1.ObservablePattern.Excercise
{
    public class Subject
    {
        private List<IObservable> observables = new List<IObservable>();

        public void AddObserver(IObservable observable)
        {
            observables.Add(observable);
        }

        public void RemoveObservable(IObservable observable)
        {
            observables.Remove(observable);
        }

        public void NotifyObservers()
        {
            foreach (IObservable observer in observables)
            {
                observer.Update();
            }
        }
    }
}
