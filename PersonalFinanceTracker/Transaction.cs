using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinanceTracker
{
    public class Transaction
    {
        public int TransactionID { get; set; }
        public double Amount { get; set; }
        public string Date {  get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }

        public Transaction(int id, double amount, string date, string type, string category, string description)
        {
            TransactionID = id;
            Amount = amount;
            Date = date;
            Type = type;
            Category = category;
            Description = description;
        }
    }

    
}
