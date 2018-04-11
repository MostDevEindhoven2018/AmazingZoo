using System;
using System.Collections.Generic;
using AmazingZoo.InheritZoo.Animals;

namespace AmazingZoo.InheritZoo.Business
{
    public class Zoo
    {
        private IList<Animal> _animals = new List<Animal>();

        public void FillZoo()
        {
            _animals.Add(new Panda(200));
            _animals.Add(new Giraff(100));
            _animals.Add(new Snake(50));

        }

        public void AddPanda(int weight)
        {
            _animals.Add(new Panda(weight));
        }

        public void AddGiraff(int weight)
        {
            _animals.Add(new Giraff(weight));
        }

        public void AddSnake(int weight)
        {
            _animals.Add(new Snake(weight));
        }

        public void IsHungry()
        {

        }

    }

    public class Food
    {



    }
}
