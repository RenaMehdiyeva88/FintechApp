using System;
using System.Collections.Generic;
using System.Text;

namespace FintechApp
{
    public class Account
    {
        public string AccountNumber { get; set; }
        public double Balance { get; set; }
        public string Currency { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }

        public Account(string accountNumber, double initialBalance, string currency, string description, string status)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
            Currency = currency;
            Description = description;
            Status = status;
        }

        public void ShowAccountDetails()
        {
            Console.WriteLine($"Account No: {AccountNumber} | Balance: {Balance} {Currency} | Description: {Description} | Status: {Status}");
        }
    }
}
