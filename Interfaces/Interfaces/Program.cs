using Interfaces.Entities;
using Interfaces.Services;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter contract data");
        int number = 8028;
        Console.WriteLine($"Number: {number}");
        var date = new DateTime(2023, 07, 25);
        Console.WriteLine($"Date (dd/MM/yyyy): {date}");
        double contractValue = 600;
        Console.WriteLine($"Contract value: {contractValue}");
        int months = 3;
        Console.WriteLine($"Enter number of installments: {months}");
        Contract newcontract = new Contract(number, date, contractValue);
        ContractService contractService = new ContractService(new PaypalService());
        contractService.ProcessContract(newcontract, months);
        Console.WriteLine("Installments: ");
        foreach (Installment installment in newcontract.Installments)
        {
            Console.WriteLine(installment);
        }
    }
}