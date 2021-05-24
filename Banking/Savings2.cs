using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    class Savings2: IBanking
    {
        private Account account { get; set; }
        public decimal InterestRate { get; set; } = 0.01m;
        public string AccountNumber {
            get {
                return account.AccountNumber;
            }
        }
        public Savings2()
        {
            account = new Account();
        }
        


        public bool Deposit(decimal amount)
        {
            return account.Deposit(amount);
        }
        public bool Transfer(Account accountTo, decimal amount)
        {
            return account.Transfer(accountTo, amount);
        }
        public bool Withdraw(decimal amount)
        {
            return account.Withdraw(amount);
        }

        public decimal CalcInMonths(int months)
        {
            return account.Balance * (InterestRate / 12) * months;
        }
        public void PayInterest(int months)
        {
            Deposit(CalcInMonths(months));
        }

        public decimal getBalance()
        {
            return account.Balance;
        }

        public string getAcctNum()
        {
            return account.AccountNumber;
        }
    }
}
