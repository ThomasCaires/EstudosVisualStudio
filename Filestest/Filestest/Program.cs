

using Filestest;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        string sourcePath = @"E:\c#\Filestest\Out\file1.txt";
        string path = @"E:\c#\Filestest\Out\summary.csv";


        try
        {
            string[] lines = File.ReadAllLines(sourcePath);
            using (StreamWriter sw = File.AppendText(path))
            {
                foreach (string line in lines)
                {
                    string[] separete = line.Split(',');
                    string name = separete[0];
                    double price = double.Parse(separete[1]);
                    int quantity = int.Parse(separete[2]);

                    Product product = new Product(name, price, quantity);
                    sw.WriteLine(product.Name + "," + product.Total().ToString("F2", CultureInfo.InvariantCulture));
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
