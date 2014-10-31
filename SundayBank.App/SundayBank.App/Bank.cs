using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SundayBank.App
{
    class Bank
    {
        public string AccountNumber { private get; set; }
        public string CustomerName { private get; set; }
        public double Balance { get; private set; }

        public Bank(string accountNumber, string customerName) 
        {
            AccountNumber = accountNumber;
            CustomerName = customerName;
        }

        public Bank(double balance)
        {
            Balance = 0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public string GetReport()
        {
            string msg = CustomerName + " , your Account Number is " + AccountNumber + " and Balance is " + Balance;
            return msg;
        }
    }
}
