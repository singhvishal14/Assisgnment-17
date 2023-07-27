using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssisgnment17
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area
        {
            get { return Width * Height; }
        }

        public override double Perimeter
        {
            get { return 2 * (Width + Height); }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Shape Type: Rectangle");
            Console.WriteLine($"Width: {Width}");
            Console.WriteLine($"Height: {Height}");
            Console.WriteLine($"Area: {Area}");
            Console.WriteLine($"Perimeter: {Perimeter}");
        }
    }
}

