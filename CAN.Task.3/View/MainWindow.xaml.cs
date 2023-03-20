using CAN.Task._3.Core;
using CAN.Task._3.View.Pages;
using System.Windows;

namespace CAN.Task._3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CoreNavigate.MyConnection = MainFrame;
            MainFrame.Navigate(new MainPage());

        }

    }
}