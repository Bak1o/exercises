using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    internal class PaymentCard
    {
        public decimal _balance { get; private set; }

        public PaymentCard(decimal balance)
        {
            
           _balance = balance;
        }

        //public void EatLunch()
        //{
        //    if (_balance >= 10.60m)
        //    {
        //        _balance = _balance - 10.60m;
        //    }
            
        //}

        //public void DrinkCoffee()
        //{
        //    if (_balance >= 2m)
        //    {
        //    _balance = _balance - 2m;

        //    }
            
        //}

        public void AddMoney(decimal increase)
        {

            _balance += increase;

        }
        public bool TakeMoney(decimal amount)
        {
            if (_balance >= amount)
            {
                _balance -= amount;
                return true;
            }
            return false;

        }

        public override string ToString()
        {
            return $" The card has balance of : {_balance} Lari ";
        }
    }
}
