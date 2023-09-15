using course;
using Course;
using System.Globalization;

int s1 = Calculator.Sum(10, 20, 30, 40);
int s2 = Calculator.Sum(23, 54, 5);

Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine();

Locatario[] vet = new Locatario[10];

Console.WriteLine("Quantos quartos serao aluagados");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine("NOME:");
    string nome = Console.ReadLine();
    Console.WriteLine("EMAIL");
    string email = Console.ReadLine();
    Console.WriteLine("QUARTO");
    int quarto = int.Parse(Console.ReadLine());
    vet[quarto] = new Locatario(nome, email);
}

for (int i = 0; i < 10; i++)
{
    if (vet[i] != null)
    {
        Console.WriteLine(i + ": " + vet[i]);
    }
}





