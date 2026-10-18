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

namespace Katkov_rpm_lab8
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        double noun1, noun2, result;
        int index_operat;
        private void cmbRole_SelectionChanged(object sender, SelectionChangedEventArgs e) // список
        {
            index_operat = cmbRole.SelectedIndex;
        }
        private void btnProcess_Click(object sender, RoutedEventArgs e) // вычислить
        {
            switch (index_operat)
            {
                case 0:
                    result = noun1 + noun2;
                    tbResult.Text = result.ToString();
                    break;
                case 1:
                    result = noun1 - noun2;
                    tbResult.Text = result.ToString();
                    break;
                case 2:
                    result = noun1 * noun2;
                    tbResult.Text = result.ToString();
                    break;
                case 3:
                    if (noun2 == 0)
                    {
                        tbResult.Text = "ДЕЛЕНИЕ НА НОЛЬ НЕ ПРЕДУСМОТРЕННО!";
                    }
                    else
                    {
                        result = noun1 / noun2;
                        tbResult.Text = result.ToString();

                    }
                    break;
            }
        }
        private void btnClear_Click(object sender, RoutedEventArgs e) // очистить
        {
            txtName.Clear();
            txtName2.Clear();
            noun1 = 0;
            noun2 = 0;
            tbResult.Text = "";
        }

        private void txtName_TextChanged(object sender, TextChangedEventArgs e) // первое поле ввода
        {
            if (double.TryParse(txtName.Text, out double ss))
            {
                noun1 = ss;
            }
            
        }

        private void txtName2_TextChanged(object sender, TextChangedEventArgs e) // второе поле ввода
        {
            if (double.TryParse(txtName2.Text, out double ss))
            {
                noun2 = ss;
            }
        }
    }
}
