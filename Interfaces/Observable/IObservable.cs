using System.Collections.Generic;
using ObserverPattern2.Interfaces.Observer;

namespace ObserverPattern2.Interfaces.Observable
{
    public interface IObservable<out T>
    {
        public List<IObserver> Observers { get; set; }
        
        public void Add(IObserver o);
        public void Remove(IObserver o);
        public void Notify();

        public T GetState();

    }
}