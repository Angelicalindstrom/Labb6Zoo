using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6Zoo
{
    // Angelica Lindström NET.23
    public abstract class Animal
    {
        //Static fields
        public string Name { get; set; }
        public string Species { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }


        // Abstract Method
        public abstract void Move();
        public abstract void Sound();
        public abstract void Eat();

        // constructor with 5 parameters 
        public Animal(string name, string species, string color, int age, int weight)
        {
            Name = name;
            Species = species;
            Color = color;
            Age = age;
            Weight = weight;
        }

    }
}
