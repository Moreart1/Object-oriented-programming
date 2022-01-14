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
            Bank bankCurrent = new Bank(14997789, 554875, AccountType.Current);
            Console.WriteLine($"{bankCurrent}\n");

            Bank bankSavings = new Bank(1554567, 192540, AccountType.Savings);
            Console.WriteLine(bankSavings);
        }
    }
}
