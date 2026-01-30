using System;
using System.Collections.Generic;
using System.Text;

namespace FintechApp
{
    public class Transaction
    {
        public string Type { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public Transaction(string type, double amount, string description)
        {
            Type = type;
            Amount = amount;
            Description = description;
            Date = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Date:yyyy-MM-dd HH:mm:ss} | {Type} | {Amount} | {Description}";
        }
    }
}
