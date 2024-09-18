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

            CalculateTriangleAreaWithRef(baseTriangle, heightTriangle, ref result);
            Console.WriteLine($"Triangle area is : {result}");

            Program instance = new Program();
            instance.CalculateTriangleAreaWithInitialisation(baseTriangle, heightTriangle);


        }

        static void CalculateTriangleArea(double b, double h)
        {
            double result = 0.5 * (b * h);
            Console.WriteLine($"Triangle area is : {result}");
        }

        // When we use an out parameter this one must be assigned.
        static void CalculateTriangleAreaWithOut(double b, double h, out double result)
        {
            result = 0.5 * (b * h);
        }

        // When we use an ref parameter we have the choice to not assign it.
        static void CalculateTriangleAreaWithRef(double b, double h, ref double result)
        {
            result = 0.5 * (b * h);
        }

        void CalculateTriangleAreaWithInitialisation(double h, double b)
        {
            double result = 0.5 * (b * h);
            Console.WriteLine($"Triangle area is : {result}");
        }
    }
}