using System;
using System.Collections.Generic;

namespace Lesson_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bank> list = new();

            Bank account1 = new Bank(500,AccountType.Current);
            Bank account2 = new Bank(4500, AccountType.Savings);
            Bank account3 = new Bank(5000, AccountType.Current);
            Bank account4 = new Bank(3100, AccountType.Savings);
            Bank account5 = new Bank(3100, AccountType.Savings);

            list.Add(account1);
            list.Add(account2);
            list.Add(account3);
            list.Add(account4);
            list.Add(account5);

            foreach (var item in list)
            {
                item.Info();
            }

            Console.WriteLine(account4==account5);
            Console.WriteLine();
            Console.WriteLine(account4 != account5);
            Console.WriteLine();
            Console.WriteLine(account4.Equals(account5));//баланс и тип счета одинаковые,но выводит false,так как мы описали сравнение еще и по номеру,а он у нас генерируется
            Console.WriteLine();
            Console.WriteLine(account3.GetHashCode());
            Console.WriteLine();
            Console.WriteLine(account2.ToString());
        }
    }
}
