using System;
namespace Inheritance
{

    public class Bird : Animal
    {
        public Bird()
        {
            sleep = "At Night";
            age = 2;
            IsHungry = true;
            habitat = "Tree";

        }
        public string BirdSong { get; set; }
        public string Food { get; set; }
        public int DistanceMigrated { get; set; }
        public string BirdColor { get; set; }

    }
}