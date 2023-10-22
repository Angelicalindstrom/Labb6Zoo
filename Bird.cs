using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6Zoo
{
    // Angelica Lindström NET.23
    internal class Bird : Animal
    {// New class Bird inherit from baseclass Animal


        public string Beak { get; }

        public string Feet  { get; }


        // constructor with 5 base parameters from Animal and 2 new parameters for the class Bird.
        public Bird (string name, string species, string color, int age, int weight, string beak, string feet)
         : base(name, species, color, age, weight)
        {
            Beak = beak;
            Feet = feet;
        }

        //Methods
        public void MakeSound()
        {
            Console.WriteLine("***Hello.. Hello! Aaahh, Kakkaahh ***");
        }


        public void InfoBird()
        {
            Console.WriteLine($"In here we got all different kind of {Species}! These 2 are called {Name}!\nAs you can see, they are: {Color}." +
                $"\nTheir age togheter is: {Age} years and they weigh aproximately {Weight} kilo togheter." +
                $"\nTheir beaks are {Beak}.\nBirds feet got {Feet}");
        }


        // Methods inherrited and overrided from Animal

        public override void Sound()
        {
            Console.WriteLine("Sound : Birds can sing melodies, humm, squeak and scream. Some birds can even talk and mimic us humans");
        }

        public override void Move()
        {
            Console.WriteLine("Move : Birds got feets, so all of the birds can walk but some birds can´t even fly despite they´ve got wings");
        }

        public override void Eat()
        {
            Console.WriteLine("Food : Birds can eats seeds, berries, fruits, other birds, eggs, fish or even garbage..");
        }

        // New method for bird

        public void Fly()
        {
            Console.WriteLine("\n***Birds are flying everywhere in the BirdCage***");
        }
    }
}
