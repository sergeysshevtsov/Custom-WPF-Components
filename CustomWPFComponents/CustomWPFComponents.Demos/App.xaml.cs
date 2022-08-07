using CustomWPFComponents.Demos.Windows;
using System.Windows;

namespace CustomWPFComponents.Demos
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new CustomDropdownMenuWindow();
            MainWindow.Show();
            
            base.OnStartup(e);
        }
    }
}
