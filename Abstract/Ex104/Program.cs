using System.Globalization;
using Ex104.Entites;

List<TaxPayer> individuals = new List<TaxPayer>();
Console.Write("Enter the number of tax payers: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Tax payer #{i} data: ");
    Console.Write("Individual or company (i/c)? ");
    char ans = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = (Console.ReadLine());
    Console.Write("Anual income: ");
    int anualIncome = int.Parse(Console.ReadLine());

    if (ans == 'i')
    {
        Console.Write("Health expenditures: ");
        double health =double.Parse(Console.ReadLine());
        individuals.Add(new Individual(name, anualIncome, health));
    }
    else
    {
        Console.Write("Number of employees: ");
        int employessN = int.Parse(Console.ReadLine());
        individuals.Add(new Company(name, anualIncome, employessN));
    }
}
double sum = 0;
Console.WriteLine();
Console.WriteLine("TAXES PAID: ");
foreach (TaxPayer ind in individuals)
{
    double v = ind.Tax();
    Console.WriteLine(ind.Name
        + ": "
        + v.ToString("F2", CultureInfo.InvariantCulture));
    sum += v;
}
Console.WriteLine("TOTAL TAXES:" + sum.ToString("F2", CultureInfo.InvariantCulture));
                    
