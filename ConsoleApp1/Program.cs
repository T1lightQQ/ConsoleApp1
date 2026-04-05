using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Storage storage = new Storage();

        while (true)
        {
            Console.WriteLine("1. Добавить фигуру");
            Console.WriteLine("2. Показать все фигуры");
            Console.WriteLine("3. Сравнить фигуры");
            Console.WriteLine("4. Рассчитать стоимость");
            Console.WriteLine("5. Выход");
            

            string choose = Console.ReadLine();

            switch (choose)
            {
                case "1":
                    Add(storage);
                    break;

                case "2":
                    ShowAll(storage);
                    break;

                case "3":
                    SravFig(storage);
                    break;

                case "4":
                    Calc(storage);
                    break;

                case "5":
                    return;
            }
        }
    }

    static void Add(Storage storage)
    {
        Console.WriteLine("1. Круг\n2. Прямоугольник\n3. Треугольник");
        string type = Console.ReadLine();

        Console.WriteLine("\nЦвет: ");
        string color = Console.ReadLine();

        switch (type)
        {
            case "1":
                Console.WriteLine("Радиус: ");
                double r = Console.ReadLine();
                storage.AddFigure(new Circle(r, color));
                break;

            case "2":
                Console.WriteLine("Ширина: ");
                double w = Console.ReadLine();
                Console.WriteLine("Высота: ");
                double h = Console.ReadLine();
                storage.AddFigure(new Rectangle(w, h, color));
                break;

            case "3":
                Console.WriteLine("A: ");
                double a = Console.ReadLine();
                Console.WriteLine("B: ");
                double b = Console.ReadLine();
                Console.WriteLine("C: ");
                double c = Console.ReadLine();
                storage.AddFigure(new Triangle(a, b, c, color));
                break;
        }
    }

    static void ShowAll(Storage storage)
    {
        var figures = storage.GetAll();
        for (int i = 0; i < figures.Length; i++)
        {
            Console.WriteLine($"{i}: {figures[i].GetInfo()}");
        }
    }

    static void SravFig(Storage storage)
    {
        Console.WriteLine("Индекс 1: ");
        int i1 = Console.ReadLine();
        Console.WriteLine("Индекс 2: ");
        int i2 = Console.ReadLine();

        var f1 = storage.GetByIndex(i1);
        var f2 = storage.GetByIndex(i2);

        if (f1 == null || f2 == null)
        {
            Console.WriteLine("Ошибка индексов");
            return;
        }

        if (f1 > f2)
            Console.WriteLine("Первая фигура больше");
        else if (f1 < f2)
            Console.WriteLine("Вторая фигура больше");
        else
            Console.WriteLine("Фигуры равны");
    }

    static void Calc(Storage storage)
    {
        Console.WriteLine("Цена за м²: ");
        double price = Console.ReadLine();

        var figures = storage.GetAll();

        foreach (var f in figures)
        {
            Console.WriteLine($"{f.Name}: {f.CalculateMaterialCost(price):F2}");
        }
    }
}