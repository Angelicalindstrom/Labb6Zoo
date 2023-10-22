using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6Zoo
{
    // Angelica Lindström NET.23
    internal class Eagle : Bird
    {// New class Eagle inherit from Bird

        //Static fields
        public int Speed { get; }
        public double Wingspan { get; }


        // constructor with 7 base parameters from Bird and 2 new parameters for the class Eagle.
        public Eagle(string name, string species, string color, int age, int weight, string beak, string feet, int speed, double wingspan )
         : base(name, species, color, age, weight, beak, feet)
        {
            Speed = speed;
            Wingspan = wingspan;
        }

        //Methods
        public void MakeSound()
        {
            Console.WriteLine("Screams ***EEeaaaahhh*** ");
        }


        public void InfoParrot()
        {
            Console.WriteLine($"This is our {Species}! His name is {Name}!\nAs you can see, he´s {Color}." +
                $"\nHe is {Age} years old and weighs {Weight} kilo" +
                $"\nHe got a {Beak} beak.\n and as you can see he got {Feet}, thats so he could grab things better with his feets while hunting!" +
                $"{Name} Wingspan is {Wingspan} meter! A {Species} top speed is : {Speed} km/h");
        }

        public override void Sound()
        {
            Console.WriteLine($"Sound : {Species} are screaming as you´ve herd when we came in here ");
        }

        public override void Move()
        {
            Console.WriteLine($"Move : {Name} Does fly and he´s really fast!");
        }

        public override void Eat()
        {
            Console.WriteLine("Food : birds, reptiles, fish, mammals, crustaceans and carrion. ");
        }


        // New method for Eagle
        public void Hunting()
        {
            Console.WriteLine("Cirkle around in the air and can see his prays for a mile away, And he Attacks!!");
        }
    }
}
