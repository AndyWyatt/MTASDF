using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTASDF.Lesson09.BitsAndBobs
{
    public class Ellipse : Polygon
    {
        public static int NoOfEliipses { get; set; }

        public Ellipse(double x, double y, double width, double height)
            : base(x, y, width, height)
        {
            NoOfEliipses++;
        }

        public override string ToString()
        {
            return $"Ellipse width = {Width}, Height = {Height}";
        }

        public double GetArea()
        {
            return Math.PI * (Width * 0.5) * (Height * 0.5);
        }
    }
}
