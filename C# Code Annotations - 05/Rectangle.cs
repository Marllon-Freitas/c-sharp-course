using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Rectangle : Shape
    {
        public double Lenght { get; set; }  

        public double Width { get; set; }   

        public Rectangle(double lenght, double width)
        {
            Name = "Rectangle";
            Lenght = lenght;
            Width = width;
        }

        public override double Area()
        {
            return Lenght * Width;
        }

        // You can replace the method using override
        public override void GetInfo()
        {
            //execute the base class GetInfo
            base.GetInfo();
            Console.WriteLine($"It has a Length of {Lenght} and a Width of {Width}");
        }
    }
}
