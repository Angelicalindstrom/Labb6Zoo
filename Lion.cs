using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6Zoo
{
    // Angelica Lindström NET.23 
    internal class Lion : Animal
    {// New class Lion inherit from baseclass Animal


        // Static fields
        public string Territory { get; }
        public string Pack { get; }

        // constructor with 5 base parameters from Animal and 2 new parameters for the class lion.
        public Lion(string name, string species, string color, int age, int weight, string territory, string pack)
            : base(name, species, color, age, weight)
        {
            
            Territory = territory;
            Pack = pack;
        }


        // Make sound Method
        public void MakeSound()
        {
            Console.WriteLine("*** Raaur... RAAUUUR!!!***");
        }

        // Output Lion
        public void InfoLion()
        {
            Console.WriteLine($"This Majestic {Species} is called {Name}! As you can see, he´s {Color}," +
                $"he is {Age} years old, He weights about {Weight} kilo." +
                $"\nHe marks his Territory by {Territory} and by the smell other lions know that this is his land!\n" +
                $"Lions are the only Cat animal in the world that´s lives and moves in pack, just like a {Pack}");
        }

        // Methods inherrited and overrided from Animal
        public override void Sound()
        {
            Console.WriteLine("Sound : The Lion ROOARS!! A Roar of a lion could be heard up to 8 km away");
        }
        public override void Move()
        {
            Console.WriteLine("Move : When the Lion move, he´s Majestic and respectful, " +
                "they can Run at 60km/h, top speed of 80km/h(for a short while)");
        }
        public override void Eat()
        {
            Console.WriteLine("Food : The Lion are carnivores, they only eat meat and hunts their pray!");
        }


        // New method for Lions
        public void Play()
        {
            Console.WriteLine("Play : The Lions plays allot together to measure their strength and " +
                "to learn the huntingskills.");
        }
        

      
    }
}
