using System;

namespace zoological_zaniness{

    public class PaintedDog : IWalking, ILandAnimal, IAnimal
    {
        public string classification { get; set; }
        public string color { get; set; }
        public string name { get; set; }
        public string movement { get; set; }

        public void Movement(string movement)
        {
            Console.WriteLine($"{name}, the Painted Dog, is a land animal that {movement}.");

        }

        public void Run()
        {
            Console.WriteLine("Animal is now running");
        }

        public void Walk()
        {
            Console.WriteLine("Animal is now walking");
        }
    }
}