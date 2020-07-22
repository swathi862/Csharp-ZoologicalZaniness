using System;

namespace zoological_zaniness{

    public class Ant : IUndergroundAnimal, ILandAnimal, IAnimal
    {
        public string classification { get; set; }
        public string color { get; set; }
        public string name { get; set; }
        public string movement { get; set; }

        public void Burrow()
        {
            Console.WriteLine($"{name}, the Ant, is an underground animal that burrows underground.");

        }

        public void Movement(string movement)
        {
            Console.WriteLine($"{name}, the Ant, is a land animal that {movement}.");

        }
    }
}