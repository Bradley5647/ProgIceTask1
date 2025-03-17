using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapeAreaCalc
{
    class Circle : Shape, ICalculateArea
    {
        public double radius { get; set; }

        public Circle(String name, double radius) : base(name)
        {
            this.radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        public override void Display()
        {
            Console.WriteLine($"Shape: {name} radius: {radius}");
        }



    }
}
