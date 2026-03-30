using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Figure : ICostable
    {
        public string Color { get; set; }
        public string Name { get; set; }

        public Figure(string name, string color)
        { Name = name; Color = color; }

        public abstract double GetArea();
        public abstract double GetPerimeter();

        public virtual string GetInfo()
        {
            return $"Имя: {Name}, Цвет: {Color}";
        }

        public static bool operator >(Figure a, Figure b)
        {
            return a.GetArea() > b.GetArea();
        }

        public static bool operator <(Figure a, Figure b)
        {
            return a.GetArea() < b.GetArea();
        }

        public static double operator +(Figure a, Figure b)
        {
            return a.GetPerimeter() + b.GetPerimeter();
        }

        public static bool operator ==(Figure a, Figure b)
        {
            if (a.GetPerimeter() == b.GetPerimeter())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Figure a, Figure b)
        {
            return !(a == b);
        }

        public double CalculateMaterialCost(double price)
        {
            return GetArea() * price;
        }
    }
}
