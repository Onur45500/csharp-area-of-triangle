using System.Xml.XPath;

namespace AreaOfTriangle
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Write the base of the triangle :");
            input = Console.ReadLine();

            double baseTriangle = Convert.ToDouble(input);

            Console.WriteLine("Write the height of the triangle :");
            input = Console.ReadLine();

            double heightTriangle = Convert.ToDouble(input);

            CalculateTriangleArea(baseTriangle, heightTriangle);

            double result = 0;
            CalculateTriangleAreaWithOut(baseTriangle, heightTriangle, out result);
            Console.WriteLine($"Triangle area is : {result}");
        }

        static void CalculateTriangleArea(double b, double h)
        {
            double result = 0.5 * (b * h);
            Console.WriteLine($"Triangle area is : {result}");
        }

        static void CalculateTriangleAreaWithOut(double b, double h, out double result)
        {
            result = 0.5 * (b * h);
        }
    }
}