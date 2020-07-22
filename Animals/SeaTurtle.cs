using System;

namespace zoological_zaniness{

    class SeaTurtle : IWalking, ISwimming, IWaterAnimal, IAnimal
    {
        int MaximumDepth { get; } = 100;

        int ISwimming.MaximumDepth => throw new NotImplementedException();

        public string classification { get; set; }
        public string color { get; set; }
        public string name { get; set; }

        public void Run()
        {
            Console.WriteLine("Animal is now running");
        }

        public void Walk()
        {
            Console.WriteLine("Animal is now walking");
        }

        public void Swim()
        {
            Console.WriteLine("Animal is now swimming");
        }

        public void Swimming()
        {
            Console.WriteLine($"{name}, the Sea Turtle, is a water animal that swims in da sea.");

        }
    }

}