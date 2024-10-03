using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PersonalFinanceTracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Budget budget = new Budget();

        private void AddTransaction_Click(object sender, RoutedEventArgs e)
        {
            AddTransaction add = new AddTransaction(budget);
            add.Show();
        }

        private void SetBudget_Click(object sender, RoutedEventArgs e)
        {
            SetBudget set = new SetBudget(budget);
            set.Show();
        }

        private void ViewBudget_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Budget:\n\nYear: {budget.Year}\nMonth: {budget.Month}\nIncome Goal: {budget.IncomeGoal}\nExpenses Limit: {budget.ExpenseLimit}\nActual Income: {budget.ActualIncome}\nActual Expense: {budget.ActualExpenses}");
            
        }

        private void TrackProgress_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            if (budget.ActualIncome > budget.IncomeGoal)
            {
                sb.AppendLine("You have earned more than your income goal for this month");
            } else
            {
                sb.AppendLine($"You have R{budget.IncomeGoal-budget.ActualIncome} left to meet your income goal for this month");
            }

            if (budget.ActualExpenses < budget.ExpenseLimit)
            {
                sb.AppendLine($"You have not yet met your expenses limit for the month. You have {budget.ExpenseLimit - budget.ActualExpenses} left");
            }
            else
            {
                sb.AppendLine($"You have exceded your budget by R{budget.ActualExpenses - budget.ExpenseLimit}");
            }

            sb.AppendLine($"Savings: {budget.ActualIncome - budget.ActualExpenses}");

        }

        private void ViewReport_Click(object sender, RoutedEventArgs e)
        {
            var categoryExpenses = budget.transactions
                .Where(t => t.Type == "expense")
                .GroupBy(t => t.Category)
                .Select(g => new
                {
                    Category = g.Key,
                    TotalAmount = g.Sum(t => t.Amount)
                })
                .ToList();

            StringBuilder sb = new StringBuilder("Expenses by Category\n");

            foreach (var category in categoryExpenses)
            {
                sb.AppendLine($"{category.Category}: {category.TotalAmount}");
            }

            MessageBox.Show(sb.ToString());
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}