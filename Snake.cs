using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6Zoo
{
    // Angelica Lindström NET.23
    internal class Snake : Animal
    {  // New class Snake inherit from baseclass Animal
        
        
        public string Skinn { get; }

        public int LongestSnake { get; }


        // constructor with 5 base parameters from Animal and 2 new parameters for the class Snake.
        public Snake(string name, string species, string color, int age, int weight, string skinn, int longestSnake)
            : base(name, species, color, age, weight)
        {
            Skinn = skinn;
            LongestSnake = longestSnake;
        }

        // Make sound Method
        public void MakeSound()
        {
            Console.WriteLine("***Schhhh.. Zzzzz...***");
        }

        // New Methods
        // output Method snake
        public void InfoSnake()
        {
            Console.WriteLine($"These Majestic {Species} are called {Name}!\nAs you can see, they are different colors: {Color}." +
                $"\nTheir age togheter is: {Age} years and they weigh aproximately {Weight} kilo togheter." +
                $"\nTheir skin is made of {Skinn} and different snakes have different patterns.\n" +
                $"The longest snake that has been found was about : {LongestSnake} meters long");
        }


        // Methods inherrited and overrided from Animal

        public override void Sound()
        {
            Console.WriteLine("Sound : The snakes can´t make that moutch sounds. But to warn they Hiss " +
                "just as you´ve heard as we arrived here.");
        }

        public override void Move()
        {
            Console.WriteLine("Move : The snakes has no legs, even though the fastest snake ''Sidewinder'' " +
                "can get top speed of 29 km/h, in sand!");
        }

        public override void Eat()
        {
            Console.WriteLine("Food : The snakes are Carnivores, Some eat warm-blooded pray (rabbits, rats, birds..)" +
                "\nwhile others eat insects, eggs, fish, frogs..");
        }

        // New Method for lions
        public void SkinPeel() 
        {
            Console.WriteLine("SkinPeel : The snake changes skin, the process is called ecodysis." +
                "\nWhen to peel depends from snake to snake, age, weather and temperature");
        }

    }
}
