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

namespace WpfApp1
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

        private void SevenBtn_Click(object sender, RoutedEventArgs e)
        {
            if (OutputPlace.Text == "0")
                OutputPlace.Text = string.Empty;

            OutputPlace.Text += "7";
        }

        private void PercentBtn_Click(object sender, RoutedEventArgs e)
        {
            OutputPlace.Text += "%";
        }

        private void CEBtn_Click(object sender, RoutedEventArgs e)
        {

            if (OutputPlace.Text != "0")
            OutputPlace.Text = string.Empty;

            OutputPlace.Text = "0";
        }

        private void Ctn_Click(object sender, RoutedEventArgs e)
        {
            if (OutputPlace.Text != "0")
                OutputPlace.Text = string.Empty;

            OutputPlace.Text = "0";

        }

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
                    
        }

        private void xBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void xxBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void XSquareBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RootBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DivisiorBtn_Click(object sender, RoutedEventArgs e)
        {
            if (OutputPlace.Text == "0")
                OutputPlace.Text = string.Empty;

            OutputPlace.Text += "/";
        }

        private void EightBtn_Click(object sender, RoutedEventArgs e)
        {
            if (OutputPlace.Text == "0")
                OutputPlace.Text = string.Empty;

            OutputPlace.Text += "8";
        }

        private void NineBtn_Click(object sender, RoutedEventArgs e)
        {
            if (OutputPlace.Text == "0")
                OutputPlace.Text = string.Empty;

            OutputPlace.Text += "9";
        }

        private void MultiplierBtn_Click(object sender, RoutedEventArgs e)
        {
            OutputPlace.Text += "*";
        }

        private void FourthBtn_Click(object sender, RoutedEventArgs e)
        {
            if (OutputPlace.Text == "0")
                OutputPlace.Text = string.Empty;

            OutputPlace.Text += "4";
        }

        private void ThreeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (OutputPlace.Text == "0")
                OutputPlace.Text = string.Empty;

            OutputPlace.Text += "3";
        }

        private void FiveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (OutputPlace.Text == "0")
                OutputPlace.Text = string.Empty;

            OutputPlace.Text += "5";
        }

        private void SixBtn_Click(object sender, RoutedEventArgs e)
        {
            if (OutputPlace.Text == "0")
                OutputPlace.Text = string.Empty;
            OutputPlace.Text += "6";
        }

        private void minusBtn_Click(object sender, RoutedEventArgs e)
        {
            OutputPlace.Text += "-";
        }

        private void OneBtn_Click(object sender, RoutedEventArgs e)
        {
            if (OutputPlace.Text == "0")
                OutputPlace.Text = string.Empty;
            OutputPlace.Text += "1";
        }

        private void TwoBtn_Click(object sender, RoutedEventArgs e)
        {
            if (OutputPlace.Text == "0")
            OutputPlace.Text = string.Empty;
                
            OutputPlace.Text += "2";
        }

        private void PlusBtn_Click(object sender, RoutedEventArgs e)
        {
            OutputPlace.Text += "+";
        }

        private void PlusMinusBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ZeroBtn_Click(object sender, RoutedEventArgs e)
        {
            if(OutputPlace.Text=="0")
                OutputPlace.Text = string.Empty;
           
            OutputPlace.Text += "0";
        }

        private void CommaBtn_Click(object sender, RoutedEventArgs e)
        {
                OutputPlace.Text += ".";
        }

        public static double Evaluate(string expression)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table.Columns.Add("expression", string.Empty.GetType(), expression);
            System.Data.DataRow row = table.NewRow();
            table.Rows.Add(row);
            return double.Parse((string)row["expression"]);
        }

        private void EqualBtn_Click(object sender, RoutedEventArgs e)
        {
            OutputPlace.Text = Evaluate(OutputPlace.Text).ToString();
        }

       
    }
}
