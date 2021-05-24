using System;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            var acc1 = new Account();
            var acc2 = new Account();
            var sav2 = new Savings2();
            var cd1 = new CD2(Amount: 1000, Months: 12);
            
            
            
            
            //cd1.Deposit(1);
            //cd1.Withdraw(1);
            //cd1.WithDate = DateTime.Now.AddDays(-1);
            //Console.WriteLine(cd1.Balance);
            //var funds = cd1.Withdraw();
            //Console.WriteLine(cd1.Balance);
            //sav2.Deposit(500);
            //sav2.InterestRate = .12m;
            //sav2.PayInterest(5);
            //Console.WriteLine();
            //acc2.Deposit(1000);
            //acc1.Deposit(500);
            //acc2.Transfer(acc1, 1100);
            //Console.WriteLine(acc1.Balance);
            //Console.WriteLine(acc2.Balance);
        }
    }
}
