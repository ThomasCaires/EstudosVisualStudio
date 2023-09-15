using Heranca.Entities;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Account> list = new List<Account>();

        list.Add(new SavingsAccounts(1001, "Alex", 500.0, 0.01));
        list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
        list.Add(new SavingsAccounts(1003, "Bob", 500.0, 0.01));
        list.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));

        int listsize = list.Count;
        Console.WriteLine($"List size: {listsize}");

        double sum = 0;
        foreach (Account acc in list)
        {
            sum += acc.Balance;
        }
        Console.WriteLine($"Total balance: {sum}");

        Console.WriteLine("Account withdraw:");
        foreach (Account acc in list)
        {
            acc.Withdraw(10.0);
        }
        foreach (Account acc in list)
        {
            Console.WriteLine(acc);
        }

        Console.WriteLine("Account to loan (account number): ");
        int n = 1002;
        if (list.Exists(x => x.Number == n) == true)
        {
            try
            {
                Account account = list.Find(a => a.Number == n);
                BusinessAccount account1 = (BusinessAccount)account;
                account1.Loan(100);
            }
            catch (InvalidCastException e)
            {
                throw new Exception(e.Message);
            }
        }
        foreach(Account acc in list)
        {
            Console.WriteLine(acc);
        }
    }
}
