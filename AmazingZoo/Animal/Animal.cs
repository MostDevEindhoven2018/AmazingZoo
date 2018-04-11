using System;

namespace AmazingZoo.InheritZoo.Animals
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int NumberOfLegs { get; set; }
        public float Weight { get; set; }
        public float Height { get; set; }
        public string CountryOfOrigin { get; set; }


        public abstract void EatPlant();

        public abstract void EatMeat();

        public abstract void MakeSounds();
    }
}
