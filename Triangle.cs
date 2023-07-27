using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssisgnment17
{
    public class Triangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public override double Area
        {
            get
            {
                // Using Heron's formula to calculate the area of a triangle
                double s = (SideA + SideB + SideC) / 2;
                return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
            }
        }

        public override double Perimeter
        {
            get { return SideA + SideB + SideC; }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Shape Type: Triangle");
            Console.WriteLine($"SideA: {SideA}");
            Console.WriteLine($"SideB: {SideB}");
            Console.WriteLine($"SideC: {SideC}");
            Console.WriteLine($"Area: {Area}");
            Console.WriteLine($"Perimeter: {Perimeter}");
        }
    }
}
