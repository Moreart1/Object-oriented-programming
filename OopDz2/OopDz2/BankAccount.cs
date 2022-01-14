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
        private static int _number = 0;
        public int Number { get { return _number++; } }

        public Bank(int accountnumber, decimal balance, AccountType type)
        {
            _Accountnumber = accountnumber;
            _Balance = balance;
            _Type = type;
        }
        private  int _Accountnumber { get; set; }
        private decimal _Balance { get; set; }

        private AccountType _Type { get; set; }
        public override string ToString() => $"Accountnumber-{Number},Balans-{_Balance},Type-{_Type}";
    }
}
