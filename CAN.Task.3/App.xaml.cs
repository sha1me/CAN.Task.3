using System.Windows;

namespace CAN.Task._3
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            new MainWindow().Show();
        }
    }
}