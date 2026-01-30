using System;
using System.Collections.Generic;
using System.Text;

namespace FintechApp
{
    public class E_Kassa
    {
        public List<Account> Accounts { get; set; }

        public E_Kassa()
        {
            Accounts = new List<Account>();
        }

        public void CreateAccount(string currency, double initialBalance, string description)
        {
            string accountNumber = GetNextAccountNumber();

            Account newAccount = new Account(accountNumber, initialBalance, currency, description, "Active");
            Accounts.Add(newAccount);
            Console.WriteLine($"New account created! Account number: {accountNumber}");
        }

        public void ShowAllAccounts()
        {
            if (Accounts.Count == 0)
            {
                Console.WriteLine("No accounts available.");
                return;
            }
            Console.WriteLine("{0,-12} {1,-10} {2,-10} {3,-20} {4,-10}", "Account No", "Currency", "Balance", "Description", "Status");
            foreach (var account in Accounts)
            {
                Console.WriteLine("{0,-12} {1,-10} {2,-10} {3,-20} {4,-10}",
                                  account.AccountNumber,
                                  account.Currency,
                                  account.Balance,
                                  account.Description,
                                  account.Status);
            }
        }

        public Account GetAccountByNumber(string accountNumber)
        {
            return Accounts.FirstOrDefault(acc => acc.AccountNumber == accountNumber);
        }
        public void ChangeAccountStatus(string accountNumber, string newStatus)
        {
            var account = GetAccountByNumber(accountNumber);
            if (account != null)
            {
                account.Status = newStatus;
                Console.WriteLine($"Account status for {accountNumber} changed to {newStatus}");
            }
            else
            {
                Console.WriteLine("Account not found.");
            }
        }

        private string GetNextAccountNumber()
        {
            List<string> predefinedAccountNumbers = new List<string> { "45637896", "45625326", "45637896" };
            int index = Accounts.Count % predefinedAccountNumbers.Count;
            return predefinedAccountNumbers[index];
        }
    }
}
