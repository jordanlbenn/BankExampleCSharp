using BankLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankServices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Account.GeneratetestAccounts();
                //arguement sent
                switch (args[0])
                {
                    case "test":
                        Console.WriteLine("Testing selected.");
                        foreach (var account in Account.Accounts)
                        {
                            Console.WriteLine(account);
                        }
                        break;
                    case "apply-interest":
                        Console.WriteLine("Applying intertest selected.");
                        InterestService interestSerivce = new InterestService();
                        interestSerivce.ApplyInterestToAccounts(Account.Accounts);
                        break;
                    default:
                        break;
                }

            }
            else
            {
                Console.WriteLine("No arguements sent");
            }
        }
    }
}
