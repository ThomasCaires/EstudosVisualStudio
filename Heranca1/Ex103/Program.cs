using Ex103.Entites;
using Ex103.Entites.Enums;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Console.Write("Enter the number od Shapes: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Shape #{i} data: ");
            Console.Write("Rectangle or Circle (r/c)? ");
            char ans = char.Parse(Console.ReadLine());
            Console.Write("Color (Black/Blue/Red): ");
            Color color = Enum.Parse<Color>(Console.ReadLine());
            if (ans == 'r')
            {
                Console.Write("Width: ");
                double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Height: ");
                double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                shapes.Add(new Rectangle(width, height, color));
            }
            else
            {
                Console.Write("Radius: ");
                double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                shapes.Add(new Circle(radius, color));
            }
        }
        Console.WriteLine();
        Console.WriteLine("SHAPES AREAS");
        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
        }

    }
}