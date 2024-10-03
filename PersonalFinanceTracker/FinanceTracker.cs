using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PersonalFinanceTracker
{
    public class FinanceTracker
    {
        Budget budget = new Budget();
        public FinanceTracker() { 
            
        }

        public void AddTransaction(Budget budget, int id, double amount, string date, string type, string category, string description)
        {
            Transaction transaction = new Transaction(id, amount, date, type, category, description);
            budget.transactions.Add(transaction);
            if (type == "income")
            {
                budget.ActualIncome += amount;
            } else if (type == "expense")
            {
                budget.ActualExpenses += amount;
            }
            MessageBox.Show("Transaction added");
        }

        public void SetBudget(Budget budget, double incomeLimit, double expenseLimit)
        {
            budget.IncomeGoal = incomeLimit;
            budget.ExpenseLimit = expenseLimit;
            budget.Year = DateTime.Now.Year;
            budget.Month = DateTime.Now.Month;
        }

        public void TrackProgress(double incomeEarned, double expensesIncurred)
        {
            budget.ActualIncome += incomeEarned;
            budget.ActualExpenses += expensesIncurred;

            if (budget.IncomeGoal <= budget.ActualIncome) {
                Console.WriteLine("Income goal achieved");
            } 

            if (budget.ExpenseLimit >= budget.ActualExpenses)
            {
                Console.WriteLine("Expense limit surpassed");
            }
        }

        public void ListTransactionsByMonth()
        {

        }

        public void ListTransactionsByCategory()
        {

        }


        public double CalculateSavings()
        {
            return budget.ActualIncome - budget.ActualExpenses;
        }

        public void IdentifyOverspending()
        {

        }

        public void PredictFutureSpending()
        {

        }

        public void GenerateReport()
        {

        }
    }
}
