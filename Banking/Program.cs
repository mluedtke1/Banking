using System;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {

            var sav2 = new Savings2();
            sav2.Deposit(2000);
            var cd1 = new CD2(Amount: 5000, Months: 60);

            var accounts = new IBanking[] { sav2, cd1 };

            foreach(var i in accounts)
            {
                Console.WriteLine(i.getBalance());
            }



            //cd1.WithDate = DateTime.Now.AddDays(-1);

            //var funds = cd1.Withdraw();
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
