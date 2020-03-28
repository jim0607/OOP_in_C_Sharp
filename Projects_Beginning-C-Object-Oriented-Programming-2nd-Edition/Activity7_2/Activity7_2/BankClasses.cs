﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activity7_2Starter
{
    class Account
    {
        private int _accountNumber;
        protected double _balance;

        public double Balance
        {
            get { return _balance; }
        }
        public int AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }
        public double GetBalance()
        {
            if (AccountNumber == 1)
            {
                _balance = 1000;
                return _balance;
            }
            else if (AccountNumber == 2)
            {
                _balance = 2000;
                return _balance;
            }
            else
            {
                throw new ApplicationException("Account number incorrect.");
            }
        }
        public virtual double Withdraw(double amount)   // keyword virtual indicates it is overridable
        {
            if (Balance >= amount)
            {
                _balance -= amount;
                return Balance;
            }
            else
            {
                throw new ApplicationException("Not enough funds.");
            }
        }
    }
    class SavingsAccount : Account
    {
    }
    class CheckingAccount : Account
    {
        public double GetMinBalance()
        {
            return 200;
        }
        // add the following overriding Withdraw method to the CheckingAccount class definition. 
        // This method adds a check to see that the minimum balance is maintained after a withdrawal.
        public override double Withdraw(double amount)
        {
            if (Balance >= amount + GetMinBalance())
            {
                _balance -= amount;
                return Balance;
            }
            else
            {
                throw new ApplicationException("Not enough funds.");
            }
        }
    }
}
