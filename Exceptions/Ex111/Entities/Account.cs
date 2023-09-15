using System;
using Ex111.Entities.Exceptions;

namespace Ex111.Entities
{
    internal class Account
    {
        public int AccountNumber { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int accountNumber, string holder, double balance, double withdrawLimit)
        {
            AccountNumber = accountNumber;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (WithdrawLimit < amount)
            {
                throw new DomainExceptions("The amount exceeds withdraw limit");
            }
            if (Balance < amount)
            {
                throw new DomainExceptions("Not enough balance");
            }
            Balance -= amount;
        }
    }
}
