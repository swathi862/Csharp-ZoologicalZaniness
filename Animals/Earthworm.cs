using System;

namespace zoological_zaniness{

    public class EarthWorm : IUndergroundAnimal, IAnimal
    {
        public string classification { get; set; }
        public string color { get; set; }
        public string name { get; set; }

        public void Burrow()
        {
            Console.WriteLine($"{name}, the Earth worm, is an underground animal that burrows itself in the dirt.");

        }
    }
}