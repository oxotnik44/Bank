using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace Bank
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        private void bt_compare_Click(object sender, RoutedEventArgs e)
        {//передача данных
            var n = tbl_stab_result.Text;
            var x = tbl_opt_result.Text;
            var j = tbl_standart_result.Text;

            double srok = Convert.ToDouble(tb_srok.Text);


            var t = Convert.ToDouble(tb_sum.Text);
            //double k = Convert.ToDouble(tb_srok.Text);
            //double s = Convert.ToDouble(tb_popoln.Text);
            double stavkastab = 0.08;
            double stavkaoptimal = 0.05;
            double stavkastandart = 0.06;
            try
            {
                double stabotvet = t * Math.Pow((1 + stavkastab / 365), srok);
                double stabotvet1 = t * Math.Pow((1 + stavkaoptimal / 365), srok);
                double stabotvet2 = t * Math.Pow((1 + stavkastandart / 365), srok);
                Window2 form = new Window2(n, x, j, stabotvet, stabotvet1, stabotvet2, srok, t);
                form.Show();
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }

        private void sl_sum_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            NumberFormatInfo nfi = new NumberFormatInfo { NumberGroupSeparator = " ", NumberDecimalDigits = 0 };
            tb_sum.Text = ((Slider)sender).Value.ToString("n", nfi);
            try
            {
                double n = Convert.ToDouble(tb_sum.Text);
                double srok = Convert.ToDouble(tb_srok.Text);
                double popoln = Convert.ToDouble(tb_popoln.Text);
                double stavkastab = 0.08;
                double stavkaoptimal = 0.05;
                double stavkastandart = 0.06;
                double m = n * stavkastab * srok / 365;
                double l = n * stavkaoptimal * srok / 365;
                double p = n * stavkastandart * srok / 365;

                tbl_stab_result.Text = Convert.ToDecimal(m).ToString("#,##0 Руб.");
                tbl_opt_result.Text = Convert.ToDecimal(l).ToString("#,##0 Руб.");
                tbl_standart_result.Text = Convert.ToDecimal(p).ToString("#,##0 Руб.");
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void sl_srok_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            NumberFormatInfo nfi = new NumberFormatInfo { NumberGroupSeparator = " ", NumberDecimalDigits = 0 };
            tb_srok.Text = ((Slider)sender).Value.ToString("n", nfi);

        }

        private void sl_popoln_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            NumberFormatInfo nfi = new NumberFormatInfo { NumberGroupSeparator = " ", NumberDecimalDigits = 0 };
            tb_popoln.Text = ((Slider)sender).Value.ToString("n", nfi);
        }
    }
}
