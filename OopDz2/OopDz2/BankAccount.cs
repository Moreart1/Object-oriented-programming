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
        public Bank(string accountnumber, decimal balance, AccountType type)
        {
            _Accountnumber = accountnumber;
            _Balance = balance;
            _Type = type;
        }
        private string _Accountnumber { get; set; }
        private decimal _Balance { get; set; }

        private AccountType _Type { get; set; }
        public override string ToString() => $"Accountnumber-{_Accountnumber},Balans-{_Balance},Type-{_Type}";
    }
}
