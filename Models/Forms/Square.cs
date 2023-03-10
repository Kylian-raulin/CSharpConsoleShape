using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsoleShape.Models.Forms
{
    public class Square : Shape
    {
        public double Width { get; set; }
        public Square(int width)
        {
            this.Width = width;
        }
        public override double Area()
        {
            return this.Width * Width;
        }
    }
}
