using ConsoleApp4;
using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal Snoopy = new Animal()
            {
                Name = "Snoopy",
                Sound = "Woof"
            };

            Cat MsMidnight = new Cat()
            {
                Name = "MsMidnight",
                Sound = "Meow",
                Sound2 = "Prrrrr"
            };

            // Demonstrate changing the protected field sound
            MsMidnight.Sound = "Wooooof";

            Snoopy.MakeSound();
            MsMidnight.MakeSound();

            // Define the AnimalIdInfo
            Snoopy.SetAnimalIdInfo(12345, "João Pedro");
            MsMidnight.SetAnimalIdInfo(12346, "Marllon Freitas");

            Snoopy.GetAnimalIdInfo();

            // Test the inner class
            Animal.AnimalHealth getHealth = new Animal.AnimalHealth();

            Console.WriteLine($"Is my animal healthy : {getHealth.HealthyWeight(11, 46)}");

            // You can define 2 Animal objects but have one actually be a Cat type. 
            Animal monkey = new Animal()
            {
                Name = "Happy",
                Sound = "Eeeeee"
            };

            Animal spot = new Cat()
            {
                Name = "Spot",
                Sound = "Meoow",
                Sound2 = "Prr"
            };

            monkey.MakeSound();

            // The problem is that if you call a 
            // function in Animal it won't call
            // the overridden method in Cat unless
            // the method that might be overridden
            // is marked virtual
            spot.MakeSound();

            // This is an example of how Polymorphism
            // allows a subclass to override a method
            // in the super class and even if the 
            // subclass is defined as the super class
            // type the correct method will be called


            Console.ReadLine();
        }

    }
}