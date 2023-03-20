﻿using CAN.Task._3.Core;
using System;
using System.Windows;
using System.Windows.Controls;

namespace CAN.Task._3.View.Pages.TaskPages
{
    public partial class Task3Page : Page
    {
        public Task3Page()
        {
            InitializeComponent();
        }

        private void BtnMainPage_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new MainPage());
        }

        private void BtnTask3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(TbX.Text);
                if (x < -5)
                    MessageBox.Show($"y = {2.8 * Math.Pow(Math.Sin(-5 * x),2) - 2.5*Math.Pow(x,3) * Math.Log10(Math.Abs(2.5 * Math.Pow(x, 3)))}", "Системное сообщение",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
                else if (x >= 3 && x <= 5)
                    MessageBox.Show($"y = {Math.Log10(Math.Abs(5 * x)) * Math.Cos(Math.Pow(3 * x + 5,2)) + Math.Log10(Math.Log10(Math.Abs(5 * x)))}", "Системное сообщение",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
                else if (x > Math.Pow(3,2))
                    MessageBox.Show($"y = {Math.Exp(2.5 * -10 *x) + Math.Log10(Math.Abs(2.5 * Math.Pow(x, 2))) * -10 * 3 * x}", "Системное сообщение",
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