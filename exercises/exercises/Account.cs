using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    internal class Account
    {
        public string AccountName {  get; set; }   
        public int AccountBalance { get; set; }

        public Account(string accountName, int accountBalance)
        {  
            AccountName = accountName; 
            AccountBalance = accountBalance; 
        }

        public void Deposit(int deposit)
        {
            AccountBalance = AccountBalance + deposit;
        }

        public void Withdrawal(int withdrawal)
        {
            AccountBalance -= withdrawal;
            
        }
        public void GetBalance()
        {
            Console.WriteLine($"your balance in {AccountName} is : {AccountBalance}");
        }

    }
}
