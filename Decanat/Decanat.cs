using System;
using System.Collections.Generic;
using System.Text;

namespace Decanat
{
    class Decanat : IObservable
    {
        public List<Post> News { get; set; }
        private List<IObserver> _observers;

        public Decanat()
        {
            News = new List<Post>();
            _observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(News);
            }
        }
    }
}
