using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingZoo.InheritZoo.Animals
{
    public class Snake : Reptile
    {
        public Snake(int weight)
        {
            Name = "Snake";
            Color = "Green";
            Weight = weight;

        }

        public override void EatMeat()
        {
            Console.WriteLine("Eating chicken.");
        }

        public override void MakeSounds()
        {
            Console.WriteLine("Siiiiiiiii");
        }
    }
}
