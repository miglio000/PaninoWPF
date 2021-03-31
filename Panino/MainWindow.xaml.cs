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

namespace Panino
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

        private void btnCalcola_Click(object sender, RoutedEventArgs e)
        {
            float somma = (float)0.00;
            if (rdbGrano.IsChecked == true)

                somma += 2;

            else if (rdbIntegrale.IsChecked == true)

                somma += 3;

            else
                somma += (float)3.50;
            if (rdbProsciutto.IsChecked == true)

                somma += 3;

            else if (rdbSalsiccia.IsChecked == true)
                somma += 4;
            else
                somma += (float)4.50;
            if (chkInsalata.IsChecked == true)
                somma += 2;
            if (chkKetchup.IsChecked == true)
                somma += (float)1.50;
            if (chkMaionese.IsChecked == true)
                somma += (float)1.50;
            lblPrezzo.Content = somma.ToString();
        }
    }
}
