using System;

namespace AmazingZoo.InheritZoo.Animals
{
    public class Mammal : Animal
    {
        public override void EatPlant()
        {
            Console.WriteLine("Mammal eats plant.");
        }

        public override void EatMeat()
        {
            Console.WriteLine("Mammal also eats meat.");
        }

        public override void MakeSounds()
        {
            Console.WriteLine("Mammal makes sounds.");
        }

        public void WarmBlood()
        {
            Console.WriteLine("Mammal has warm blood");
        }
    }
}
