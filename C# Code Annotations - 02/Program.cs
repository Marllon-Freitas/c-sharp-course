using ConsoleApp2;
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a rectangle in a "struct way"
            Rectangle rect1;

            // Add values to it and run the Area method
            rect1.length = 200;
            rect1.width = 500;
            Console.WriteLine($"The Area of rect1 : {rect1.Area()}");

            // Use a constructor to create a Rectangle
            Rectangle rect2 = new Rectangle(100, 40);

            // If you assign one Rectangle to another
            // you are setting the values and not creating a reference

            rect2 = rect1;
            rect1.length = 33;
            Console.WriteLine($"rect2.lenght : {rect2.length}");

            // ----- OBJECT ORIENTED PROGRAMMING -----
            // A class models real world objects by
            // defining their attributes (fields) and
            // capabilities (methods)
            // Then unlike with struts you can 
            // inherit from a class and create more
            // specific subclass types

            // Add a class Project -> Add Class

            // Create an Animal object
            // You could also assign values like
            // fox.name = "Red"

            //---- create Animals
            Animal Dog = new Animal()
            {
                name = "Puppy",
                sound = "Bark"
            };
            Animal Cat = new Animal()
            {
                name = "Kitten",
                sound = "Miau"
            };

            Dog.MakeSound();
            Cat.MakeSound();

            // Call the static method
            Console.WriteLine($"Actual Quantity of Animals : {Animal.GetNumAnimals()}");

            // You can also create static utility
            // classes Project -> Add Class
            Console.WriteLine($"Area of Rectangle : {ShapeMath.GetArea("Rectangle", 7, 6)}");
            Console.WriteLine($"Area of Triangle : {ShapeMath.GetArea("Triangle", 3, 4)}");
            Console.WriteLine($"Area of Circle : {ShapeMath.GetArea("Circle", 5, 7)}");

            // ----- NULLABLE TYPES -----
            // Data types by default cannot have a
            // value of null. Often null is needed
            // when you are working with databases
            // and you can create a null type by 
            // adding a ? to the definition
            int? randNum = null;

            // Check for null
            if (randNum == null)
            {
                Console.WriteLine("randNum is null");
            }

            // Another check for null
            if (!randNum.HasValue)
            {
                Console.WriteLine("randNum is null");
            }


            Console.ReadLine();
        }

        // ----- STRUCTS -----
        // Struts it is basically a user define type, they contain multiple fields and methods
        struct Rectangle
        {
            public double length;
            public double width;

            // You can create a constructor method
            // that will set the values for fields
            public Rectangle(double l = 1, double w = 1)
            {
                length = l;
                width = w;
            }
            public double Area()
            {
                return length * width;
            }
        }
    }
}