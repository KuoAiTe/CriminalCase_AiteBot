using System;
using System.Collections.Generic;
using System.Windows;
namespace AiteCriminal
{
    //[STAThread]
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MainWindow a = new MainWindow();
            a.Show();
            Console.WriteLine("aa");
        }
    }
}