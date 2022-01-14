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
        private static int _number = 1;
        public int Number { get { return _number++; } }
        
        private decimal _Balance { get; set; }

        private AccountType _Type { get; set; }

        
        public Bank(decimal balance)
        {
            _Balance = balance;
        }
        public Bank(AccountType type)
        {
            _Type = type;
        }
       
        public Bank(decimal balance,AccountType type)
        {
            _Balance = balance;
            _Type = type;
        }
        public override string ToString() => $"Accountnumber-{Number},Balans-{_Balance},Type-{_Type}";
    }
}
