using System;

namespace ConsoleApp2
{
    // only contains static methods
    // static === we don't need to create a object to use it 
    class ShapeMath
    {
        public static double GetArea(string shape = "", double lenght1 = 0, double lenght2 = 0)
        {
            if (String.Equals("Rectangle", shape, StringComparison.OrdinalIgnoreCase))
            {
                return lenght1 * lenght2;
            } else if (String.Equals("Triangle", shape, StringComparison.OrdinalIgnoreCase)) {
                return lenght1 * (lenght2 / 2);
            } else if (String.Equals("Circle", shape, StringComparison.OrdinalIgnoreCase))
            {
                return 3.14159 * Math.Pow(lenght1, 2);
            } else
            {
                return -1;
            }


        }
    }
}
