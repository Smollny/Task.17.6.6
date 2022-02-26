using System;

namespace Task._17._6._6
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Account { Balance = 500000 };
            account.CalculateInterest(new SalaryAccount());
            Console.WriteLine(account.Interest);

            account = new Account { Balance = 500000 };
            account.CalculateInterest(new UsualAccount());
            Console.WriteLine(account.Interest);
            Console.ReadKey();
        }
    }
}
