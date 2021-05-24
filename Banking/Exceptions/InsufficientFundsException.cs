using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Exceptions
{
    public class InsufficientFundsException : Exception
    {
        public decimal Amount { get; set; }
        public decimal balance { get; set; }

        public InsufficientFundsException() : base()
        {

        }
        public InsufficientFundsException(string message) : base(message)
        {

        }
        public InsufficientFundsException(string message, Exception InnerException) : base(message, InnerException)
        {

        }

        public InsufficientFundsException(decimal Amount, decimal balance) : base()
        {
            this.Amount = Amount;
            this.balance = balance;
        }

    }
}
