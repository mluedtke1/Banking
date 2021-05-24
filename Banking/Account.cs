using Banking.Exceptions;
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

        //transfer method
        public bool Transfer(Account acctTo, decimal amount)
        {
            if (Withdraw(amount))
            {
                acctTo.Deposit(amount);
                return true;
            }
            return false;
        }

        //deposit method
        public virtual bool Deposit(decimal depAmnt)
        {
            if(depAmnt < 0)
            {
                var ex = new InvalidParameterException();
                ex.Amount = depAmnt;
                throw ex;
            }
            Balance += depAmnt;
            return true;
        }

        //withdraw method
        public virtual bool Withdraw(decimal wdrAmnt)
        {
            if(wdrAmnt < 0)
            {
                //var ex = new InvalidParameterException();
                //ex.Amount = wdrAmnt;
                //throw ex;
                throw new InvalidParameterException(wdrAmnt);
            }
            if(wdrAmnt > Balance)
            {
                throw new InsufficientFundsException(wdrAmnt, Balance);
            }

            Balance -= wdrAmnt;
            return true;
        }


    }
}
