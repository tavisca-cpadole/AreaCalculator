using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaFinder
{
    public class Square : Shape
    {
        int length;
        public Square(int length)
        {
            this.length = length;
        }
        public override double Area()
        {
            return length* length;
        }
    }
}
