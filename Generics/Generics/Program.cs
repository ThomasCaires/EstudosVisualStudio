using Generics;

internal class Program
{
    private static void Main(string[] args)
    {
        PrintService<string> printservice = new PrintService<string>();
        Console.Write("how many values? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string x = Console.ReadLine();
            printservice.AddValue(x);
        }

        printservice.Print();
        Console.WriteLine($"First: {printservice.First()}");
    }
}