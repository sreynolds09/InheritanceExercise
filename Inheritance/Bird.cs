using System;
namespace Inheritance
{

    public class Bird : Animal
    {
        public Bird()
        {
            sleep = "At Night";
            age = 2;
            isHungry = true;
            habitat = "Tree";

        }
        public string birdSong { get; set; }
        public string food { get; set; }
        public int distanceMigrated { get; set; }
        public string birdColor { get; set; }

    }
}