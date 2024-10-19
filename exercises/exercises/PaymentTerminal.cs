using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    class PaymentTerminal
    {
        private decimal _money;
        private int _coffeeAmount;
        private int _lunchAmount;
        //private decimal _change;

        public PaymentTerminal()
        {
            _money = 1000m;
            //_change = 0;
           
        }

        public decimal DrinkCoffee(decimal payment)
        {
            decimal change = 0;
            if (payment > 2.50m)
            {
                
                _coffeeAmount++;

                 _money += 2.50m;
                change = payment - 2.50m;
                return change;
                

            }
            else if (payment == 2.50m)
            {
                _coffeeAmount++;
                 _money += 2.50m;
                return change;
            }
            else
            {
                return change;
            }
        }

        public bool DrinkCoffee(PaymentCard card)
        {
            if (card._balance >= 2.50m)
            {
                card.TakeMoney(2.50m);
                _coffeeAmount++;
                return true;
            }
            return false;

        }
        public decimal EatLunch(decimal payment)
        { decimal change = 0;
            if (payment > 10.30m)
            {
                
                _lunchAmount++;
                 _money += 10.30m;
                change = payment - 10.30m;
                return change;
            }
        else if (payment == 10.30m)
            {
                _lunchAmount++;
                 _money += 10.30m;
                return change;
            }
        return change;

        }

        public bool EatLunch(PaymentCard card)
        {
            if (card._balance >= 10.30m)
            {
                card.TakeMoney(10.30m);
                _lunchAmount++;
                return true;
            }
            return false;
        }

        public void AddMoneyToCard(PaymentCard card, decimal sum)
        {
            card.AddMoney(sum);
        }

        public override string ToString()
        {
            return $" money : {_money}, number of sold coffees : {_coffeeAmount}, number of sold lunches : {_lunchAmount} ";
        }
    }
}
