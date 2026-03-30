using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Triangle : Figure
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public Triangle(double side1, double side2, double side3, string color) : base("Треугольник", color)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public override double GetArea()
        {
            double p = GetPerimeter();
            return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
        }

        public override double GetPerimeter()
        {
            return Side1 + Side2 + Side3;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $"Стороны: {Side1}, {Side2}, {Side3}, Площадь:{GetArea()}, Периметр:{GetPerimeter()}";
        }
    }
}
