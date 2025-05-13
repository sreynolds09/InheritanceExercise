using System;
namespace Inheritance
{
    
    public class Reptile : Animal
    {
        public Reptile()
        {
            sleep = "During the Day";
            age = 100;
            isHungry = true;
            habitat = "Water";
            
        }
        public bool isColdBlooded { get; set; }
        public bool hasScales { get; set; }
        public bool isAmphibious { get; set; }
        public int age { get; set; }

    }
}