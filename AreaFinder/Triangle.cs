using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaFinder
{
    public class Triangle : Shape
    {
        int breadth, length;
        public Triangle(int breadth,int length){
            this.breadth = breadth;
            this.length = length;
        }
        public override double Area() {
            return 0.5 * breadth * length;
        }
    }
}
