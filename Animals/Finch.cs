using System;

namespace zoological_zaniness{

    public class Finch : ISkyAnimal, IAnimal
    {
        public string classification { get; set; }
        public string color { get; set; }
        public string name { get; set; }

        public void Flying()
        {
            Console.WriteLine($"{name}, the Finch, is a sky animal that flies.");

        }
    }
}