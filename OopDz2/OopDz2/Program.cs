using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OopDz2
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank Account1 = new Bank(100);
            Console.WriteLine(Account1);

            Bank Account2 = new Bank(AccountType.Savings);
            Console.WriteLine(Account2);

            Bank Account3 = new Bank(145000, AccountType.Current);
            Console.WriteLine(Account3);
            
        }
    }
}
