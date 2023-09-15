using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Entities
{
    class SavingsAccounts : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccounts()
        {

        }

        public SavingsAccounts(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance + InterestRate;
        }

        public sealed override void Withdraw(double amount)//sobreposiçao de classe
        {
            base.Withdraw(amount);//utilizando base podemos chamar o metodp comum da superclasse
            Balance -= 2.0;
        }
    }
}
