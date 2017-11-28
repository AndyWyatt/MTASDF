using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTASDF.Lesson09.BitsAndBobs
{
    public class Rectangle : Polygon
    {
        public Rectangle(double x, double y, double width, double height)
            : base(x, y, width, height)
        {

        }

        public override string ToString()
        {
            return $"Rectangle (W = {Width}, H = {Height})";
        }

        public double GetArea()
        {
            return Width * Height;
        }
    }
}
