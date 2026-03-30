using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Circle : Figure
    {
        public double Radius { get; set; }
        
        public Circle(double radius, string color) : base ("Круг", color)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return 3.14 * Radius * Radius;
        }

        public override double GetPerimeter()
        {
            return 2 * 3.14 * Radius;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $", Радиус: {Radius}, Площадь {GetArea()}, Периметр: {GetPerimeter()}";
        }
    }
}
