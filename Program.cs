using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssisgnment17
{
     class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle { ShapeType = "Circle", Radius = 4 };
            Rectangle rectangle = new Rectangle { ShapeType = "Rectangle", Width = 4, Height = 5 };
            Triangle triangle = new Triangle { ShapeType = "Triangle", SideA = 3, SideB = 5, SideC = 7 };

            circle.PrintInfo();
            Console.WriteLine();

            rectangle.PrintInfo();
            Console.WriteLine();

            triangle.PrintInfo();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
    }

