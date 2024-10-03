using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PersonalFinanceTracker
{
    /// <summary>
    /// Interaction logic for SetBudget.xaml
    /// </summary>
    public partial class SetBudget : Window
    {
        Budget Budget;
        public SetBudget(Budget budget)
        {
            InitializeComponent();
            Budget = budget;
        }


        private void setBtn_Click(object sender, RoutedEventArgs e)
        {
            Budget.IncomeGoal = double.Parse(incomeTB.Text);
            Budget.ExpenseLimit = double.Parse(expensesTB.Text);
            Budget.ActualIncome = 0;
            Budget.ActualExpenses = 0;
            Budget.Year = DateTime.Now.Year;
            Budget.Month = DateTime.Now.Month;
            MessageBox.Show("Budget set");
        }
    }
}
