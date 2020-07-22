using System;

namespace zoological_zaniness{

    public class BetaFish : IWaterAnimal, IAnimal
    {
        public string classification { get; set; }
        public string color { get; set; }
        public string name { get; set; }

        public void Swimming()
        {
            Console.WriteLine($"{name}, the Beta Fish, is a water animal that swims.");

        }
    }
}