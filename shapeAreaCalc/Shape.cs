using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapeAreaCalc
{
    public abstract class Shape
    {
        public String name { get; set; }

        public Shape(String name)
        {
            this.name = name;
        }
        virtual public void Display()
        {
            Console.WriteLine($"Shape: {name}");
        }
    }
}
