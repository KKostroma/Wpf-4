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

namespace WpfЗадание4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDouble=rateDollar * sumDollar;
            resSum.Text = resDouble.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEvro = Convert.ToDouble(rate1.Text);
            double sumEvro = Convert.ToDouble(sum1.Text);
            double res1Double = rateEvro * sumEvro;
            resSum1.Text = res1Double.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateGrivna = Convert.ToDouble(rate2.Text);
            double sumGrivna = Convert.ToDouble(sum2.Text);
            double res2Double = rateGrivna * sumGrivna;
            resSum2.Text = res2Double.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateDrama = Convert.ToDouble(rate3.Text);
            double sumDrama = Convert.ToDouble(sum3.Text);
            double res3Double = rateDrama * sumDrama;
            resSum3.Text = res3Double.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double rateInch = Convert.ToDouble(rate4.Text);
            double res4Double = rateInch * 0.0254;
            resSum4.Text = res4Double.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double rateFoot = Convert.ToDouble(rate5.Text);
            double res5Double = rateFoot * 0.3048;
            resSum5.Text = res5Double.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double rateMile = Convert.ToDouble(rate6.Text);
            double res6Double = rateMile * 1609.34;
            resSum6.Text = res6Double.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double rateVerst = Convert.ToDouble(rate7.Text);
            double res7Double = rateVerst * 1066.8;
            resSum7.Text = res7Double.ToString();
        }
    }
}
