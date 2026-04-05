using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Storage
{
    private Figure[] _figures;

    public Storage(int size = 10)
    {
        _figures = new Figure[size];
    }

    public void AddFigure(Figure f)
    {
        for (int i = 0; i < _figures.Length; i++)
        {
            if (_figures[i] == null)
            {
                _figures[i] = f;
                return;
            }
        }
        Console.WriteLine("хранилище заполнено");
    }

    public Figure[] GetAll()
    {
        int count = 0;
        foreach (var f in _figures)
            if (f != null) count++;

        Figure[] result = new Figure[count];
        int index = 0;

        foreach (var f in _figures)
            if (f != null)
                result[index++] = f;

        return result;
    }

    public double GetTotalArea()
    {
        double total = 0;
        foreach (var f in _figures)
            if (f != null)
                total += f.GetArea();

        return total;
    }

    public Figure GetByIndex(int index)
    {
        if (index >= 0 && index < _figures.Length)
            return _figures[index];
        return null;
    }
}