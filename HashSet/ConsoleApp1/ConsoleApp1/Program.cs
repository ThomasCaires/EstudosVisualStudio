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

            //SORTEDSET E HASHSET
            SortedSet<int> x = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> y = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            //juntando as duas coleçoes
            //UNION
            SortedSet<int> z = new SortedSet<int>(x);
            z.UnionWith(y);

            PrintCollection(x);
            PrintCollection(z);

            //INTERSECTION
            SortedSet<int> z1 = new SortedSet<int>(x);
            z1.IntersectWith(y);
            PrintCollection(z1);

            //DIFERENCE
            SortedSet<int> z2 = new SortedSet<int>(x);
            z2.ExceptWith(y);
            PrintCollection(z2);
        }
        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T item in collection)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}