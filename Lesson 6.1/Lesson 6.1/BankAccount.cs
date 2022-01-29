using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lesson_6._1
{
    enum AccountType { Current, Savings }
    class Bank
    {
         static int counter = 1;

        private int _number;
        public int Number
        {
            get
            {
                return _number;
            }
            set
            {
                if (value.GetType().ToString() == "System.Int32")
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
                if (value.GetType().ToString() == "System.Decimal")
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
                if (value.GetType().ToString() == "OopDz2.AccountType")
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

        public Bank(decimal balance, AccountType type)
        {
            _balance = balance;
            _typeAccount = type;
            _number = Addition();
        }
        public void Info()
        {
            Console.WriteLine($"Тип счёта: {_typeAccount}, Номер счёта: {_number}, Баланс: {_balance}\n");
        }
        public void DepositMoney(int number, int put)
        {
            if (number == _number)
            {
                Console.WriteLine($"Тип счёта: {_typeAccount}, Номер счёта: {_number}, Баланс: {_balance}\n");
                _balance += put;
                Console.WriteLine($"Счет   {_number} пополнен на: {put}");
                Console.WriteLine($"Теперь ваш баланс: {_balance}");

            }
        }
        public void TakeofMoney(int number, int take)
        {
            if (number == _number)
            {
                if (_balance >= take)
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
        public void MoneyTransfer(Bank FromMoney, decimal take)
        {
            if (FromMoney._balance > take)
            {
                _balance = _balance + take;
                FromMoney._balance = FromMoney._balance - take;
                Console.WriteLine($"На счёт: {_number}; Зачислена сумма {take}; Остаток на счету: {_balance};");
                Console.WriteLine($"Со счёта: {FromMoney._number}; Списана сумма: {take}; Остаток на счету: {FromMoney._balance};");
            }
            else
            {
                Console.WriteLine($"Недостаточно средств на счёте: {FromMoney._number}, для списания суммы: {take}");
            }
        }
        public static bool operator ==(Bank x1,Bank x2)
        {
            if (x1.Balance ==x1.Balance&&x1.TypeAccount==x2.TypeAccount)
            {
                return true;
            }
            else
            {
               return false;
            }
            
        }
        public static bool operator !=(Bank x1, Bank x2)
        {
            if (x1.Balance != x1.Balance && x1.TypeAccount != x2.TypeAccount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode()
        {
            return Number.GetHashCode() + TypeAccount.GetHashCode() + Balance.GetHashCode();
        }
        public override string ToString()
        {
            return $"Тип счёта: {_typeAccount}, Номер счёта: {_number}, Баланс: {_balance}\n";
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Bank);
        }
        public bool Equals(Bank account)
        {
            if (account is null)
            {
                return false;
            }
            else
            {
                return account.Number == Number && account.TypeAccount == TypeAccount && account.Balance == Balance;
            }
            
        }
    }
}
