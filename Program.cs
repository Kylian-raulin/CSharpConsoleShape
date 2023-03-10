// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using CSharpConsoleShape.Models.Forms;


class Program
{
    static void Main(string[] args)
    {
        Shape[] formes = new Shape[] { new Rectangle(12, 14), new Circle(5), new Triangle(7,5), new Square(10) };
        AreaCalculator areaCalculator = new AreaCalculator();

        Console.WriteLine(calcultor.TotalArea(formes));
        Console.ReadLine();
    }
}
public class AreaCalculator
{
    public static double TotalArea(Shape[] arrShapes)
    {
        double area = 0;
        foreach (var objShape in arrShapes)
        {

                area += objShape.Area();
        }
        return area;
    }
}