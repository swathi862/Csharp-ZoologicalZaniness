using System;

namespace zoological_zaniness
{
    class Program
    {
        static void Main(string[] args)
        {
            Ant Susie = new Ant();
            Susie.classification = "Insect";
            Susie.color = "black";
            Susie.name = "Susie";
            Susie.movement = "walks";

            BetaFish Chad = new BetaFish();
            Chad.name = "Chad";
            Chad.classification = "Fish";
            Chad.color = "iridescent";

            Copperhead Steve = new Copperhead();
            Steve.name = "Steve";
            Steve.color = "brown";
            Steve.classification = "Reptiles";
            Steve.movement = "slithers";

            EarthWorm Edward = new EarthWorm();
            Edward.classification = "Invertebrae";
            Edward.color = "pink";
            Edward.name = "Edward";

            Finch Sally = new Finch();
            Sally.classification = "Bird";
            Sally.color = "brown";
            Sally.name = "Sally";

            Gerbil Andrew = new Gerbil();
            Andrew.name = "Andrew";
            Andrew.classification = "Rodent";
            Andrew.color = "brown";

            Mouse Gus = new Mouse();
            Gus.name = "Gus";
            Gus.classification = "Rodent";
            Gus.color = "gray";
            Gus.movement = "runs";

            PaintedDog Rascal = new PaintedDog();
            Rascal.classification = "Mammal";
            Rascal.name = "Rascal";
            Rascal.color = "black and brown";
            Rascal.movement = "canters";

            Parakeet Noah = new Parakeet();
            Noah.color = "green";
            Noah.name = "Noah";
            Noah.classification = "Bird";

            SeaTurtle Tyler = new SeaTurtle();
            Tyler.name = "Tyler";
            Tyler.classification = "Reptile";
            Tyler.color = "dark green";

            Terrapin Charlie = new Terrapin();
            Charlie.name = "Charlie";
            Charlie.classification = "Reptile";
            Charlie.color = "dark green";
            Charlie.movement = "ambles";

            Rattlesnake Lucifer = new Rattlesnake();
            Lucifer.color = "tan";
            Lucifer.name = "Lucifer";
            Lucifer.classification = "Reptile";
            Lucifer.movement = "slithers";

            Cage birdCage = new Cage();
            birdCage.skyAnimals.Add(Sally);
            birdCage.skyAnimals.Add(Noah);

            Tank burrowingAnimals = new Tank();
            burrowingAnimals.undergroundAnimals.Add(Susie);
            burrowingAnimals.undergroundAnimals.Add(Edward);
            burrowingAnimals.undergroundAnimals.Add(Susie);

            burrowingAnimals.undergroundAnimals.ForEach(animal => animal.Burrow());

            Tank landAnimalTank = new Tank();
            landAnimalTank.landAnimals.Add(Susie);
            landAnimalTank.landAnimals.Add(Steve);
            landAnimalTank.landAnimals.Add(Gus);
            landAnimalTank.landAnimals.Add(Rascal);
            landAnimalTank.landAnimals.Add(Charlie);
            landAnimalTank.landAnimals.Add(Lucifer);

            landAnimalTank.landAnimals.ForEach(animal => animal.Movement(animal.movement));

            Aquarium fishTank = new Aquarium();
            fishTank.waterAnimals.Add(Chad);
            fishTank.waterAnimals.Add(Tyler);
            fishTank.waterAnimals.Add(Charlie);

            fishTank.waterAnimals.ForEach(water => water.Swimming());

            Console.WriteLine();


        }
    }
}
