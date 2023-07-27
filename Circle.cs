using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssisgnment17
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double Area
        {
            get { return Math.PI * Radius * Radius; }
        }

        public override double Perimeter
        {
            get { return 2 * Math.PI * Radius; }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Shape Type: Circle");
            Console.WriteLine($"Radius: {Radius}");
            Console.WriteLine($"Area: {Area}");
            Console.WriteLine($"Perimeter: {Perimeter}");
        }
    }
}