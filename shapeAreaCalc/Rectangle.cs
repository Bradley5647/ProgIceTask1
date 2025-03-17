using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapeAreaCalc
{
    class Rectangle : Shape, ICalculateArea
    {
        public double width { get; set; }
        public double height { get; set; }

        public Rectangle(String name, double width, double height) : base(name)
        {
            this.width = width;
            this.height = height;
        }

        public double CalculateArea()
        {
            return width * height;
        }

        public override void Display()
        {
            Console.WriteLine($"Shape: {name}, Width: {width}, Height: {height}");
        }
    }
}
