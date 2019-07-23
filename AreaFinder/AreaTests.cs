using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AreaFinder
{
    public class AreaTests
    {
        
        [Fact]
        public void CircleAreaCheck() {
            Circle circleObject = new Circle(3);
            
            Assert.Equal("28.26", Convert.ToString(circleObject.Area()));
        }
        [Fact]
        public void SquareAreaCheck()
        {
            Square squareObject = new Square(3);

            Assert.Equal("9", Convert.ToString(squareObject.Area()));
        }
        [Fact]
        public void RectangleAreaCheck()
        {
            Rectangle rectObject = new Rectangle(3,4);

            Assert.Equal("12", Convert.ToString(rectObject.Area()));
        }
        [Fact]
        public void TriangleAreaCheck()
        {
            Triangle triangleObject = new Triangle(3,4);

            Assert.Equal("6", Convert.ToString(triangleObject.Area()));
        }
    }
}
