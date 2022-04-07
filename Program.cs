using System;
using ObserverPattern2.Classes.Observable;
using ObserverPattern2.Classes.Observer;

// A simple example of the Observer pattern

namespace ObserverPattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            var character1 = new Character("Bob", 10, "a sword");
            var observer1 = new ConsoleCharacterDisplay(character1);
            character1.Add(observer1);
            observer1.Display();
            character1.SetHealth(3);
            character1.SetHealth(5);
            character1.SetHealth(0);
        }
    }
}