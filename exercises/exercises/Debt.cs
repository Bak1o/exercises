using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    internal class Debt
    {
        public decimal Balance { get; set;}
        public decimal InterestRate { get; set;}

        public Debt(decimal initialBalance, decimal initialInterest) 
        {
            Balance = initialBalance;
            InterestRate = initialInterest;
        } 
        public void WaitOneYear()
        {
            Balance = Balance * InterestRate;
        }

        public override string ToString()
        {
            return Balance.ToString();
        }
    }
}
