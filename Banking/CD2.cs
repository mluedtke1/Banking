using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    class CD2
    {
        private Account account = new Account();
        public DateTime DepDate { get; set; }
        public DateTime WithDate { get; set; }

        public bool Withdraw()
        {
            if (DateTime.Now < WithDate)
            {
                Console.WriteLine("cannot withdraw until date");
                return false;
            }
            return account.Withdraw(account.Balance);
        }

        public CD2(decimal Amount, int Months)
        {
            var success = account.Deposit(Amount);
            var interestRate = 0.0m;

            switch (Months)
            {
                case 12: interestRate = 0.01m; break;
                case 24: interestRate = 0.01m; break;
                case 36: interestRate = 0.01m; break;
                case 48: interestRate = 0.01m; break;
                case 60: interestRate = 0.01m; break;
                default: break;
            }
            var interest = account.Balance * (interestRate / 12) * Months;
            success = account.Deposit(interest);
            WithDate = DepDate.AddMonths(Months);
        }
    }
}
