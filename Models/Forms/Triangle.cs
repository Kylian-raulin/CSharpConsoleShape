using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsoleShape.Models.Forms
{
    public class Triangle : Shape
    {
        public double Height { get; set; }
        public double Base { get; set; }
        public override double Area()
        {
            return this.Height * this.Base /2;
        }
        public Triangle(double heigth, double baseTriangle)
        {
            this.Height = heigth;
            this.Base = baseTriangle;
        }
    }
}
