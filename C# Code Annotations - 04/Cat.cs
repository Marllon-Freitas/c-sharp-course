using ConsoleApp4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    // When you inherit from another class you
    // receive all of its fields and methods
    // You cannot inherit from multiple classes
    class Cat : Animal
    {
        // You can add additional properties or fields
        public string Sound2 { get; set; } = "Prrr";
        // You can overwrite methods by adding new
        /*
        public new void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound} and {Sound2}");
        }
        */

        // Add override so that the correct method
        // is called when a Cat is created as an
        // Animal type
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound} and {Sound2}");
        }

        // Create a constructor that has the base 
        // constructor initialize everything except 
        // Sound2
        public Cat(string name = "No Name", string sound = "No Sound", string sound2 = "No Sound 2") : base(name, sound)
        {
            Sound2 = sound2;
        }
    }

}
