using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsoleShape.Models.Forms
{
    public class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public override double Area()
        {
            return this.Height * this.Width * Math.PI;
        }
        public Rectangle(double heigth, double width)
        {
            this.Height = heigth;
            this.Width = width;
        }
    }
}

