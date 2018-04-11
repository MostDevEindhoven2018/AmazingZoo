using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingZoo.InheritZoo.Animals
{
    public class Giraff : Mammal
    {
        public Giraff(int weight)
        {
            Name = "Giraff";
            Color = "Yellow";
            Weight = weight;

        }

        public override void EatPlant()
        {
            Console.WriteLine("Eating grass.");
        }

        public override void MakeSounds()
        {
            Console.WriteLine("Wooooooooo");
        }
    }
}
