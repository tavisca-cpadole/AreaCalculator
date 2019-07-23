using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaFinder
{
    public class Circle : Shape
    {
        int length;
        public Circle(int length)
        {
            this.length = length;
        }
        public override double Area()
        {
            return 3.14 * length * length;
        }
    }
}
