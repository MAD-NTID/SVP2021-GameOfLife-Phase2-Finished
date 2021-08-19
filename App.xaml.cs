using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace GameOfLifeDesktop
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App() // 2.4
        { // 2.4
            Current.MainWindow = new MyMainWindow(); // 2.4
            Current.MainWindow.Show(); // 2.4
        } // 2.4
    }
}
