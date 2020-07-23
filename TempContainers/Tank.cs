using System;
using System.Collections.Generic;

namespace zoological_zaniness{

    public class Tank{

        public List<ILandAnimal> landAnimals {get; set;} = new List<ILandAnimal>();

        public List<IUndergroundAnimal> undergroundAnimals {get; set;} = new List<IUndergroundAnimal>();
    }
}