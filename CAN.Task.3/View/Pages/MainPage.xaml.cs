using CAN.Task._3.Core;
using CAN.Task._3.View.Pages.TaskPages;
using System.Windows;
using System.Windows.Controls;
namespace CAN.Task._3.View.Pages
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void BtnTask1_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Task1Page());
        }

        private void BtnTask2_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Task2Page());
        }

        private void BtnTask3_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Task3Page());
        }

        private void BtnTask4_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Task4Page());
        }

        private void BtnTask5_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Task5Page());
        }

        private void BtnTask6_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Task6Page());
        }

        private void BtnTask7_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Task7Page());
        }
    }
}
