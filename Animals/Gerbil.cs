using System;

namespace zoological_zaniness{

    public class Gerbil : IUndergroundAnimal, IAnimal
    {
        public string classification { get; set; }
        public string color { get; set; }
        public string name { get; set; }

        public void Burrow()
        {
            Console.WriteLine($"{name}, the Gerbil, is an underground animal that burrows itself underground in the wild.");

        }
    }
}