using ClientApp.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {

        MainWindow _mainWindow;
        public MainWindowViewModel(MainWindow mw)
        {
            _mainWindow = mw;
        }


        public string Greeting => "Welcome to Avalonia!";
    }
}
