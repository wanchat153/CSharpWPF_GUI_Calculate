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

namespace CSharpWPF_GUI_Calculate
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

        private void textSalary_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textExpenses_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textWant_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void submitBtn_Click(object sender, RoutedEventArgs e)
        {
            //ราคาของที่ต้องการ / (เงินเดือน - รายจ่าย)
            textShow.Text = (int.Parse(textWant.Text) / ((int.Parse(textSalary.Text) - int.Parse(textExpenses.Text)))).ToString();
            MessageBox.Show("Success");
        }

        private void textShow_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
