using CAN.Task._3.Core;
using System;
using System.Windows;
using System.Windows.Controls;

namespace CAN.Task._3.View.Pages.TaskPages
{
    public partial class Task7Page : Page
    {
        public Task7Page()
        {
            InitializeComponent();
        }

        private void BtnMainPage_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new MainPage());
        }

        private void BtnTask7_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(TbX.Text);
                if (x > Math.Log10(0.1))
                    MessageBox.Show($"y = {Math.Sqrt(Math.Pow(9.8,2) + Math.Sqrt(Math.Abs(x + 11.12)))}", "Системное сообщение",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
                else if (x == Math.Log10(10))
                    MessageBox.Show($"y = {Math.Cos(x - 10.05 - 6.2)}", "Системное сообщение",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
                else if (x < Math.Log10(100))
                    MessageBox.Show($"y = {Math.Sin(x + 100 - 3.03)}", "Системное сообщение",
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