using CAN.Task._3.Core;
using System;
using System.Windows;
using System.Windows.Controls;

namespace CAN.Task._3.View.Pages.TaskPages
{
    public partial class Task4Page : Page
    {
        public Task4Page()
        {
            InitializeComponent();
        }

        private void BtnMainPage_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new MainPage());
        }
        private void BtnTask4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(TbX.Text);
                if (Math.Abs(1 - Math.Pow(x,2)) == 3.2 + 2.2)
                    MessageBox.Show($"y = {x * Math.Exp(3.2) + Math.Exp(Math.Abs(-0.7 * 2.2))}", "Системное сообщение",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
                else if (Math.Abs(1 - Math.Pow(x, 2)) > 10.5 + 5.6)
                    MessageBox.Show($"y = {Math.Pow(Math.Sin(10.5 * x),2) + Math.Cos(-2.5 * 5.6)}", "Системное сообщение",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
                else if (Math.Abs(1 - Math.Pow(x, 2)) < 5.4 + 2.6)
                    MessageBox.Show($"y = {Math.Sqrt(5.4 * Math.Pow(3,4) + Math.Sqrt(2.6 * Math.Pow(x,2)))}", "Системное сообщение",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
                else MessageBox.Show("Не удовлетворяет условию функции", "Системное сообщение",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);

                TbX.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}