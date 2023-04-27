using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module17_Practice
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Account> accounts = new List<Account>()
            {
                new RegularAccount(100000, "Alex"),
                new SalaryAccount(100000, "Bob"),
                new SalaryAccount(500000, "Mary")
            };

            foreach (Account account in accounts)
            {
                account.CalculateInterest();
                Console.WriteLine($"Процентная ставка {account.Name}: {account.Interest}");
            }

            Console.ReadKey();
        }
    }
}

