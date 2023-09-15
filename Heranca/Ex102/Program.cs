using Ex102.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Product> list = new List<Product>();

        Console.Write("Enter the number of products: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write("Product #" + i + " data:");
            Console.Write("Common, used or imported (c/u/i)? ");
            char ans = char.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine());
            if (ans == 'c')
            {
                list.Add(new Product(name, price));
            }
            if (ans == 'u')
            {
                Console.Write("Manufacture date (DD/MM/YYYY): ");
                DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                list.Add(new UsedProduct(name, price, manufactureDate));
            }
            if (ans == 'i')
            {
                Console.Write("Customs fee: ");
                double fee = double.Parse(Console.ReadLine());
                list.Add(new ImportedProduct(name, price, fee));
            }
        }

        Console.WriteLine();
        Console.WriteLine("PRICE TAGS:");

        foreach (Product product in list)
        {
            Console.WriteLine(product.PriceTag());
        }
    }
}