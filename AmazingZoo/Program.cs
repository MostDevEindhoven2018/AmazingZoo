using System;
using System.Collections.Generic;
using AmazingZoo.InheritZoo.Animals;
using AmazingZoo.InheritZoo.Business;

namespace AmazingZoo.InheritZoo
{
    public class Snake : Reptile
    {
        public Snake(int weight)
        {
            Weight = weight;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            IAnimal animal = new Panda(150);

            Zoo zoo = new Zoo();


            zoo.FillZoo();
            zoo.IsHungry();




            Console.ReadKey();
        }
    }
}
