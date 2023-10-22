using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6Zoo
{
    // Angelica Lindström NET.23
    internal class Parrot : Bird
    {// New class Parrot inherit from Bird

        //Static field
        public string Talk { get; }

        // constructor with 7 base parameters from Bird and 1 new parameters for the class Parrot.
        public Parrot (string name, string species, string color, int age, int weight, string beak, string feet, string talk)
         : base(name, species, color, age, weight, beak, feet)
        {
            Talk = talk;
        }

        //Methods
        public void MakeSound()
        {
            Console.WriteLine("Parrot Talks :***Hello, you´re great... Give me your hat! Bye bye ***");
        }


        public void InfoParrot()
        {
            Console.WriteLine($"This is our Best {Species}! His name is {Name}!\nAs you can see, he´s {Color}." +
                $"\nHe is {Age} years old and weighs {Weight} kilo" +
                $"\nHe got a {Beak} beak.\n and as you can see he got {Feet}, thats so he could grab things better with his feets!");
        }

        public override void Sound()
        {
            Console.WriteLine("Sound : Sings: Twinkle, Tinkle little star as I wounder where you are?**");
        }

        public override void Move()
        {
            Console.WriteLine("Move : This guy cant fly so good but he´s a really good climber, and he jumps really good!");
        }

        public override void Eat()
        {
            Console.WriteLine("Food : He loves berries and fruits..");
        }

        // New method for Parrot

        public void Dance()
        {
            Console.WriteLine($"Dance: {Name} is Jumping up and down and rocking his head up and down");
        }

    }
}
