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
    /// Interaction logic for AddTransaction.xaml
    /// </summary>
    public partial class AddTransaction : Window
    {
        Budget Budget;
        public AddTransaction(Budget budget)
        {
            InitializeComponent();
            Budget = budget;
        }

        FinanceTracker ft = new FinanceTracker();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ft.AddTransaction(Budget, Int32.Parse(idTB.Text), Int32.Parse(amountTB.Text), dateTB.Text, typeTB.Text, categoryTB.Text, descriptionTB.Text);
        }
    }
}
