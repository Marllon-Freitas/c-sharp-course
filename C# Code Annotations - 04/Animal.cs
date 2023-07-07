using ConsoleApp4;
using System;

namespace ConsoleApp4
{
    class Animal
    {
        private string name;

        // A protected field can be changed by a subclass directly
        protected string sound;

        // Inheritance has a "is-a" relationship,
        // while an aggregation or delegate
        // represents a "Has-a" relationship
        // like we have here with the AnimalIDInfo object
        protected AnimalIdInfo animalIdInfo = new AnimalIdInfo();

        public void SetAnimalIdInfo(int idNumber, string owner)
        {
            animalIdInfo.IdNumber = idNumber;
            animalIdInfo.Owner = owner;
        }

        public void GetAnimalIdInfo()
        {
            Console.WriteLine($"{Name} has the id of {animalIdInfo.IdNumber} and is owned by {animalIdInfo.Owner}");
        }

        // Added virtual so that this method can
        // be overridden by subclasses
        // You must add override to the method in
        // the subclass
        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound}");
        }

        public Animal() : this("No Name", "No Sound") { }

        public Animal(string name) : this(name, "No Sound") { }

        public Animal(string name, string sound)
        {
            Name = name;
            Sound = sound;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Any(char.IsDigit))
                {
                    name = "No Name";
                    Console.WriteLine("Can't use number in the animal name");
                }
                else
                {
                    name = value;
                }
            }
        }

        public string Sound
        {
            get { return sound; }
            set
            {
                if (value.Length > 10)
                {
                    sound = "No Sound";
                    Console.WriteLine("Sound is invalid");
                }
                else
                {
                    sound = value;
                }
            }
        }

        // You can create inner classes that are
        // normally helper classes for the outer
        // class because it can access private
        // members of the outer class
        public class AnimalHealth
        {
            public bool HealthyWeight(double height, double weight)
            {
                double calc = height / weight;

                if ((calc >= .18) && (calc <= .27))
                {
                    return true;
                }
                else return false;
            }

        }
    }
}