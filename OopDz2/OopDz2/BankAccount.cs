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
            Console.WriteLine($"Тип счёта: {_typeAccount}, Номер счёта: {_number}, Баланс: {_balance}");
        }
        
    }
}
