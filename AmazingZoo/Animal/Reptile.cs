using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingZoo.InheritZoo.Animals
{
    public class Reptile : Animal
    {
        public override void EatPlant()
        {
            Console.WriteLine("Reptile eats plant.");
        }
        public override void EatMeat()
        {
            Console.WriteLine("Reptile also eats meat.");
        }

        public override void MakeSounds()
        {
            Console.WriteLine("Reptile does not make sounds.");
        }

        public void ColdBlood()
        {
            Console.WriteLine("Reptile has cold blood.");
        }
    }
}
