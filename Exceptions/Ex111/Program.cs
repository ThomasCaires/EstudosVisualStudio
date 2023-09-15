using Ex111.Entities;
using Ex111.Entities.Exceptions;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Account data");
        int number = 8021;
        Console.Write("Number:" + number);
        string holder = "Bob brown";
        Console.Write("Holder:" + holder);
        double balance = 600.00;
        Console.WriteLine("Initial balance:" + balance);
        double withdrawLimit = 300.00;
        Console.WriteLine("Withdraw limit:" + withdrawLimit);

        Account acc = new Account(number, holder, balance, withdrawLimit);

        Console.WriteLine();
        double amount = 250.00;
        Console.WriteLine("Enter amount for withdraw: ");
        try//BLOCO TRY CONTEM A PARTE DO CODIGO QUE PODE CAUSAR UMA EXCEÇÃO
        {
            acc.Withdraw(amount);
            Console.WriteLine("New balancce: " + acc.Balance);
        }
        catch (DomainExceptions e)//BLOCO CATCH CONTEM O CODIGO QUE DEVE SER RXECUTADO CASO O A EXCEÇÃO OCORRA
        {
            Console.WriteLine("Withdraw error:" + e.Message);
        }

    }
}