using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Exceptions
{
    public class InvalidParameterException : Exception //all exceptions should inherit the Exception class


    {
        public decimal Amount { get; set; }

        //three constructors - first that is default, second that passes message, third that passes message and inner
        public InvalidParameterException() : base()
        {

        }
        public InvalidParameterException(string message) : base(message)
        {

        }
        public InvalidParameterException(string message, Exception InnerException) : base(message, InnerException)
        {

        }

        //constructor that will return amount
        public InvalidParameterException(decimal amount) : base()
        {
            this.Amount = amount;
        }

    }
}
