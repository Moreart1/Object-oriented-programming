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
            List<Bank> ListBank = new();

            Bank Account1 = new Bank(100);
            Account1.DepositMoney(1,500);
            Account1.TakeofMoney(1, 300);
            Account1.Info();

            Bank Account2 = new Bank(AccountType.Savings);
            Account2.Info();
            Account2.TakeofMoney(2, 155);
            
            Bank Account3 = new Bank(145000, AccountType.Current);
            Account3.Info();
            Account3.DepositMoney(3, 13000);
            Account3.TakeofMoney(3, 140000);
            ListBank.Add(Account1);
            ListBank.Add(Account2);
            ListBank.Add(Account3);


            int _fromTheAccount = 1;
            bool there_is_no_such_account = true;
            string account_selection;
            bool _isTake = true;
            decimal _take = 0;

            Console.WriteLine("Выберете счёт на который будут переведены деньги:");
            account_selection = Console.ReadLine();

            switch (account_selection)
            {
                case "1":

                    Console.WriteLine("Выбран счет №1");
                    Console.WriteLine("Выберете счёт с которого будут переведены деньги:");
                    try
                    {

                        _fromTheAccount = int.Parse(Console.ReadLine());
                        foreach (var item in ListBank)
                        {
                            if (item.Number == _fromTheAccount)
                            {
                                there_is_no_such_account = false;
                                break;
                            }
                        }
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Не корректный номер счёта");
                    }
                    Console.WriteLine("Выберите сумму,которую хотите списать со счета");
                    try
                    {
                        _take = decimal.Parse(Console.ReadLine());
                        _isTake = false;
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Нельзя списать такое колличество");
                    }
                    Account1.MoneyTransfer(ListBank[_fromTheAccount - 1], _take);
                    break;


                case "2":
                    Console.WriteLine("Выбран счет №2");
                    Console.WriteLine("Выберете счёт с которого будут переведены деньги:");
                    try
                    {
                        _fromTheAccount = int.Parse(Console.ReadLine());
                        foreach (var item in ListBank)
                        {
                            if (item.Number == _fromTheAccount)
                            {
                                there_is_no_such_account = false;
                                break;
                            }
                        }
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Не корректный номер счёта");
                    }
                    Console.WriteLine("Выберите сумму,которую хотите списать со счета");
                    try
                    {
                        _take = decimal.Parse(Console.ReadLine());
                        _isTake = false;
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Нельзя списать такое колличество");
                    }
                    Account2.MoneyTransfer(ListBank[_fromTheAccount - 1], _take);
                    break;

                case "3":
                    Console.WriteLine("Выбран счет №3");
                    Console.WriteLine("Выберете счёт с которого будут переведены деньги:");
                    try
                    {
                        _fromTheAccount = int.Parse(Console.ReadLine());
                        foreach (var item in ListBank)
                        {
                            if (item.Number == _fromTheAccount)
                            {
                                there_is_no_such_account = false;
                                break;
                            }
                        }
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Не корректный номер счёта");
                    }
                    Console.WriteLine("Выберите сумму,которую хотите списать со счета");
                    try
                    {
                        _take = decimal.Parse(Console.ReadLine());
                        _isTake = false;
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Нельзя списать такое колличество");
                    }
                    Account3.MoneyTransfer(ListBank[_fromTheAccount - 1], _take);
                    break;
                default:
                    break;
            }
        }

    }
    }

