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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HelloWorldGUI
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

        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIncome.Text))
            {
                if (!string.IsNullOrEmpty(txtExpenses.Text))
                {
                    if (!string.IsNullOrEmpty(txtPrice.Text))
                    {
                        double calDay = Math.Ceiling(double.Parse(txtPrice.Text.Trim()) / (double.Parse(txtIncome.Text.Trim()) - double.Parse(txtExpenses.Text.Trim())));
                        txtDay.Text = calDay.ToString();
                    }
                    else
                    {
                        MessageBox.Show("โปรดระบุราคาของที่อยากได้");
                    }
                }
                else
                {
                    MessageBox.Show("โปรดระบุรายจ่าย");
                }
            }
            else
            {
                MessageBox.Show("โปรดระบุรายได้");
            }
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            txtIncome.Clear();
            txtExpenses.Clear();
            txtPrice.Clear();
            txtDay.Clear();
        }

        private void TxtCheckDigit(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
                e.Handled = true;
        }
    }
}
