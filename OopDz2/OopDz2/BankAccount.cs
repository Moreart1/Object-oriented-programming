using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopDz2
{
    enum AccountType { Current, Savings }
    
    class Bank
    {
        private static int counter = 1;

        private int _number;
        public int Number
        {
            get
            {
               return _number;
            }
            set
            {
               
              _number = value;
                
            }
        }
       private decimal _balance;

        public decimal Balance
        {
            get
            {
                return _balance;
            }
            set
            {              
               _balance = value;  
            }

        }

        AccountType _typeAccount;

        public AccountType TypeAccount
        {
            get
            {
                return _typeAccount;
            }
            set
            {
               _typeAccount = value;               
            }
        }
        int Addition()
        {
            return counter++;
        }
        public Bank()
        {
            _number = Addition();
        }
        public Bank(decimal balance)
        {
            _balance = balance;
            _number = Addition();
        }
        public Bank(AccountType type)
        {
            _typeAccount = type;
            _number = Addition();
        }
       
        public Bank(decimal balance,AccountType type)
        {
            _balance = balance;
            _typeAccount = type;
            _number = Addition();
        }
        public void Info()
        {
            Console.WriteLine($"Тип счёта: {_typeAccount}, Номер счёта: {_number}, Баланс: {_balance}\n");
        }
        public void DepositMoney(int number,int put)
        {
            if (number==_number)
            {
                Console.WriteLine($"Тип счёта: {_typeAccount}, Номер счёта: {_number}, Баланс: {_balance}\n");
                _balance += put;
                Console.WriteLine($"Счет   {_number} пополнен на: {put}") ;
                Console.WriteLine($"Теперь ваш баланс: {_balance}");
                
            }
        }
        public void TakeofMoney(int number,int take)
        {
            if (number==_number)
            {
                if (_balance>=take)
                {
                    Console.WriteLine($"Тип счёта: {_typeAccount}, Номер счёта: {_number}, Баланс: {_balance}\n");
                    _balance -= take;
                    Console.WriteLine($"Со счета  {_number} сняли :{take}");
                    Console.WriteLine($"Ваш баланс :{_balance}");
                    
                }
                else
                {
                    Console.WriteLine($"На счету недостаточно средств.Ваш баланс: {_balance}\n");
                }
            }
        }
    }
}
