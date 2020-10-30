using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulation
{
   public class BankAccount
    {
        private double balance = 0.0;

        public void Deposit(double amountToDeposit)
        {
            balance += amountToDeposit;
        }

        public double GetBalance()
        {
            return balance;

        }
    }
}
