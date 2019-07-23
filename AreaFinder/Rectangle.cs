using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaFinder
{
    public class Rectangle : Shape
    {
        int breadth, length;
        public Rectangle(int breadth, int length)
        {
            this.breadth = breadth;
            this.length = length;
        }
        public override double Area()
        {
            return breadth * length;
        }
    }
}
