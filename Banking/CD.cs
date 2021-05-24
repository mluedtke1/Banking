using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    class CD : Account
    {
        public DateTime depDate { get; set; } = DateTime.Now;
        public DateTime withDate { get; set; }
        public int Duration { get; set; }
        public decimal InterestRate { get; set; }

        public override bool Deposit(decimal amount)
        {
            Console.WriteLine("Account already funded");
            return false;
        }

        public override bool Withdraw(decimal amount)
        {
            Console.WriteLine("Withdraw after the withdraw date to receive funds");
            return false;
        }

        public bool Withdraw()
        {
            if(DateTime.Now < withDate)
            {
                Console.WriteLine("Wait until withdraw date to receive funds");
                return false;
            }
            return base.Withdraw(Balance);
        }

        private void CalcPayInt()
        {
            var interest = Balance * (InterestRate / 12) * Duration;
            Deposit(interest);
        }

        private void SetDurationAndRate(int Duration)
        {
            switch (Duration)
            {
                case 12:
                    withDate = depDate.AddMonths(Duration);
                    InterestRate = 0.01m;
                    break;
                case 24:
                    withDate = depDate.AddMonths(Duration);
                    InterestRate = 0.02m;
                    break;
                case 36:
                    withDate = depDate.AddMonths(Duration);
                    InterestRate = 0.03m;
                    break;
                case 48:
                    withDate = depDate.AddMonths(Duration);
                    InterestRate = 0.04m;
                    break;
                case 60:
                    withDate = depDate.AddMonths(Duration);
                    InterestRate = 0.05m;
                    break;
                default:
                    break;
            }

            
        }
        public CD(decimal Amount, int Duration)
        {
            this.Duration = Duration;
            SetDurationAndRate(Duration);
            Deposit(Amount);
        }
    }
}
