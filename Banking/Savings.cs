using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    class Savings : Account
    {
        public decimal InterestRate { get; set; } = 0.01m;

        public decimal CalcInMonths(int months)
        {
            return Balance * (InterestRate/12) * months;
        }
        public void PayInterest(int months)
        {
            Deposit(CalcInMonths(months));
        }

    }
}
