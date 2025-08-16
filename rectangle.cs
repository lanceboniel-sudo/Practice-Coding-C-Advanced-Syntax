using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Rectangle
{
    public int Length { get; set; }
    public int Width { get; set; }

    public int CalculateArea()
    {
        return Length * Width;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter length: ");
        int length = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter width: ");
        int width = Convert.ToInt32(Console.ReadLine());

        Rectangle rect = new Rectangle
        {
            Length = length,
            Width = width
        };

        Console.WriteLine("Area of the rectangle is " + rect.CalculateArea());
    }
}
