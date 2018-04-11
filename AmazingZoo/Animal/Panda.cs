using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingZoo.InheritZoo.Animals
{
    public class Panda : Mammal
    {
        public Panda(int weight)
        {
            Name = "Panda";
            Color = "BlackAndWhite";
            Weight = weight;

        }

        public override void EatPlant()
        {
            Console.WriteLine("Eating bamboo.");
        }

        public override void MakeSounds()
        {
            Console.WriteLine("Munnnnnnn");
        }

    }
}
