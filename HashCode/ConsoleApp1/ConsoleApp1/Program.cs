using ConsoleApp1.Entities;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "thomas";
            string b = "bianca";

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.GetHashCode());//se o codigo dos objetos é diferente então os objetos são diferentes
            Console.WriteLine(b.GetHashCode());

            Client cliente1 = new Client { Name = "thomas", Email = "thomas@gmail.com" };
            Client cliente2 = new Client { Name = "bianca", Email = "bianca@gmail.com" };

            Console.WriteLine(cliente1.GetHashCode());
            Console.WriteLine(cliente2.GetHashCode());
        }
    }
}