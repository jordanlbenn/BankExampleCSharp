using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public class CheckingAccount : Account
    {
        public decimal OverdraftLimit {get; private set; }
        public CheckingAccount(string accountNumber, string accountName, decimal initalBalance, decimal overDraftLimit) :
            base(accountNumber,accountName,initalBalance)
        {
            OverdraftLimit = overDraftLimit;
        }
        public override void Withdraw(decimal amount)
        (
            if (amount <= 0) throw new ArguementException("Withdraw amount must be positive");
            if (amount > Balance + OverdraftLimit) throw new InvalidOperationException("Overdraft limit exceeded");
            this.Withdraw(amount);
        )
    }
}
