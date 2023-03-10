using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsoleShape.Models.Forms
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }


    }
}
