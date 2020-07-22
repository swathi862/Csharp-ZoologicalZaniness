using System;

namespace zoological_zaniness{

    public class Terrapin : IWaterAnimal, ILandAnimal, IAnimal
    {
        public string classification { get; set; }
        public string color { get; set; }
        public string name { get; set; }
        public string movement { get; set; }

        public void Movement(string movement)
        {
            Console.WriteLine($"{name}, the Terrapin, is a land animal that {movement}.");

        }

        public void Swimming()
        {
            Console.WriteLine($"{name}, the Terrapin, is a water animal that swims.");

        }
    }
}