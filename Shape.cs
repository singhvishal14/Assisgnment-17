using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssisgnment17
{
    public class Shape
    {
        public string ShapeType { get; set; }

        public virtual double Area
        {
            get { return 0; }
        }

        public virtual double Perimeter
        {
            get { return 0; }
        }
    }
}

