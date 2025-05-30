using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class BankAccount
    {
        private decimal balance;


        public BankAccount(decimal balance)
        {
            Deposit(balance);
        }

        public decimal GetBalance()
        {

            return balance;
        }

        public void Deposit(decimal amount)
        {
            if(amount<=0)
            {
                Console.WriteLine("the amount cannot be negative");
            }
               

            balance += amount;
        }


        public void withdraw(decimal amount) {

            if (amount <= 0)
            {
                Console.WriteLine("Amount must be greater than 0");
            }
            else if (amount > balance)
            {
                Console.WriteLine("withdrawl amount cannot be more than balance amount")
            }

            balance += amount;

        }
    }
}
