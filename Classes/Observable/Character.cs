using System.Collections.Generic;
using ObserverPattern2.Interfaces.Observable;
using ObserverPattern2.Interfaces.Observer;

namespace ObserverPattern2.Classes.Observable
{
    public class Character : IObservable<Character>
    {
        public List<IObserver> Observers { get; set; } = new List<IObserver>();

        public int Health { get; set; }

        public string Name { get; set; }
        private string Weapon { get; set; }

        public Character(string name, int health, string weapon)
        {
            Name = name;
            Health = health;
            Weapon = weapon;
        }

        public void Add(IObserver o)
        {
            Observers.Add(o);
        }

        public void Remove(IObserver o)
        {
            Observers.Remove(o);
        }

        public void Notify()
        {
            Observers.ForEach(o => o.Update());
        }

        public Character GetState()
        {
            return this;
        }

        public void SetHealth(int health)
        {
            Health = health;
            Notify();
        }
    }
}