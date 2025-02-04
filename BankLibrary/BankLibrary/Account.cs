﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public abstract class Account
    {
        public string AccountNumber { get; private set; }
        public string AccountHolder { get; private set; }
        public decimal Balance { get: private set; }
        public Account(string accountNumber, string accountHolder, decimal balance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = balance;
        }
        public virtual void Deposit(decimal amount)
        {
            if (amount < 0) {throw new ArguementException("Deposit amount must be positive");}
            Balance += amount;
        }
        public virtual void Withdraw(decimal amount)
        {
            if (amount < 0) {throw new ArguementException("Withdraw amount must be positive");}
            if (amount > Balance) {throw new InvalidOperationException("insufficient funds");}
            Balance -= amount;
        }
    }
}
