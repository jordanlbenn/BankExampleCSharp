using BankLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankServices
{
    public class InterestService
    {
        public void ApplyInterestToAccounts(List<Account> accounts)
        {
            foreach (var account in accounts)
            {
                if (account is SavingsAccount savingsAccount)
                {
                    savingsAccount.ApplyInterest();
                    Console.WriteLine($"Bonus Interest applied to SavingsAccount ({highInterestSavingsAccount.AccountNumber}) New Balnce {highInterestSavingsAccount.Balance:C}");
                }

                if (account is HighInterestSavingsAccount highInterestSavingsAccount)
                {
                    highInterestSavingsAccount.ApplyInterest();
                    highInterestSavingsAccount.ApplyBonusinterest(0, 01m);
                    Console.WriteLine($"bonuc Interest applied to SavingsAccount ({highInterestSavingsAccount.AccountNumber}) New Balance {highInterestSavingsAccount.Balance:C}");
                }
            }
        }

        internal void ApplyInterestToAccounts(List<Account> accounts)
        {
            throw new NotImplementedException();
        }
    }
}