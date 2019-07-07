using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows;

namespace AiteCriminal
{
    //[STAThread]
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();

        }
    }
}