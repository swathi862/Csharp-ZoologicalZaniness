using System;

namespace zoological_zaniness{

    public class Mouse : ILandAnimal, IAnimal
    {
        public string classification { get; set; }
        public string color { get; set; }
        public string name { get; set; }
        public string movement { get; set; }

        public void Movement(string movement)
        {
            Console.WriteLine($"{name}, the Mouse, is a land animal that {movement}.");

        }
    }
}