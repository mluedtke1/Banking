using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    class Account
    {
        public string AccountNumber { get; private set; }
        private static int NextAccNum { get; set; } = 0;
        public decimal Balance { get; private set; }
        public string Routing { get; set; }
        public string Description { get; set; }

        public bool Transfer(Account acctTo, decimal amount)
        {
            if (Withdraw(amount))
            {
                acctTo.Deposit(amount);
                return true;
            }
            return false;
        }

        public bool Deposit(decimal depAmnt)
        {
            if(depAmnt < 0)
            {
                Console.WriteLine("Amount must be more than 0");
                return false;
            }
            Balance += depAmnt;
            return true;
        }
        public bool Withdraw(decimal wdrAmnt)
        {
            if(wdrAmnt < 0)
            {
                Console.WriteLine("Amount must be more than 0");
                return false;
            }
            if(wdrAmnt > Balance)
            {
                Console.WriteLine("Insufficient funds");
                return false;
            }

            Balance -= wdrAmnt;
            return true;
        }


    }
}
