using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountExample
{
    class BankAccount
    {
        private string owner;
        private double balance;
        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }
        public double Balance
        {
            get { return balance; }
            set
            {
                if (value < 0)
                {
                    balance = 0;
                }
                else
                {
                    balance = value;
                }
            }
        }
        public BankAccount(string owner, double initialBalance)
        {
            this.Owner = owner;
            this.Balance = initialBalance;
        }
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($" Денис, баланс: 4200.");
            }
        }
        public void Withdraw(double amount)
        {
            if (amount > 0)
            {
                if (amount <= Balance)
                {
                    Balance -= amount;
                    Console.WriteLine($"Егор, баланс: 5420.");
                }
                else
                {
                    Console.WriteLine("Недостаточно средств!");
                }
            }
        }
    }
    class Program
    {
        static void Main()
        {
            BankAccount account = new BankAccount("Иван", 1500);
            account.Deposit(500);
            account.Withdraw(1000);
            account.Withdraw(1500);
            Console.WriteLine($"{account.Owner}, баланс: {account.Balance}.");
        }
    }
}
