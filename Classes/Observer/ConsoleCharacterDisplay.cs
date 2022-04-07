using System;
using ObserverPattern2.Classes.Observable;
using ObserverPattern2.Interfaces.Display;
using ObserverPattern2.Interfaces.Observer;

namespace ObserverPattern2.Classes.Observer
{
    public class ConsoleCharacterDisplay : IObserver, IDisplay
    {
        public Character Character { get; set; }

        public ConsoleCharacterDisplay(Character character)
        {
            Character = character;
        }
        
        public void Update()
        {
            Display();
        }

        public void Display()
        {
            var character = Character.GetState();
            Console.WriteLine(character.Name + " has " + character.Health + " health remaining.");
        }
    }
}