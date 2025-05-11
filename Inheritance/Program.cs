using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var bird = new Bird();

            bird.BirdColor = "Orange and Green";
            bird.BirdSong = "tweet tweet tweet tweet tweet";
            bird.Food = "sugar water";
            bird.DistanceMigrated = 100;



            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *
             * Creatively display the class member values
             */

            var reptile = new Reptile();
            reptile.hasScales = true;
            reptile.isAmphibious = true;
            reptile.isColdBlooded = true;
            reptile.age = 20;

            var myAnimals = new Animal[] { bird, reptile };

            foreach (var animal in myAnimals)
            {
                Console.WriteLine($"This animal is {animal.age} years old");
                Console.WriteLine($"This animal is found in {animal.habitat}");
                Console.WriteLine($"Is this animal hungry? {animal.IsHungry}");
                Console.WriteLine($"This animal sleeps at {animal.sleep}");
                Console.WriteLine($"");
            }
            
            
            
        }
    }
}
