using System;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            var acc1 = new Account();
            var acc2 = new Account();
            var sav1 = new Savings();
            sav1.Deposit(500);
            sav1.InterestRate = .12m;
            sav1.PayInterest(5);
            Console.WriteLine(sav1.Balance);
            //acc2.Deposit(1000);
            //acc1.Deposit(500);
            //acc2.Transfer(acc1, 1100);
            //Console.WriteLine(acc1.Balance);
            //Console.WriteLine(acc2.Balance);
        }
    }
}
