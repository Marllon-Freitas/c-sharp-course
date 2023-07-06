using ConsoleApp3;
using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal();
            Animal dog = new Animal();

            // Call the setter
            cat.SetName("Whiskers");
            dog.SetName("Snoopy");

            // Set the property
            cat.Sound = "Meow";
            dog.Sound = "Bark";

            Console.WriteLine($"The cat is named {cat.GetName()} and says {cat.Sound}");
            Console.WriteLine($"The dog is named {dog.GetName()} and says {dog.Sound}");

            // Test auto generated getters and setters
            cat.Owner = "Marllon";
            dog.Owner = "joão";

            Console.WriteLine($"{cat.GetName()} owner is {cat.Owner}");

            // Get the read-only id number
            Console.WriteLine($"{cat.GetName()} farm id is {cat.idNum}");

            // Test static property
            Console.WriteLine($"Number of Animals : {Animal.NumOfAnimals}");


            Console.ReadLine();

        }

    }
}