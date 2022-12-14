using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using ClientApp.Stores;
using ClientApp.Views;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Tmds.DBus;

namespace ClientApp.ViewModels
{
    public class LoginPageViewModel: ViewModelBase
    {
        
        private string _username = string.Empty;

        public string UserName
        {

            get
            {
                return _username;
            }

            set
            {
                _username = value;
                OnPropertyChanged(nameof(UserName));

            }
        }

        private string _password= string.Empty;

        public string Password
        {

            get
            {
                return _password;
            }

            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));

            }
        }

        LoginPage _loginPage;
        public LoginPageViewModel(LoginPage lp)
        {
            _loginPage = lp;
        }
        public void LoginCommand()
        {
            bool booltool = true;
            if (booltool)
            {
                Window homePage = new HomePage();
                homePage.Show();
                _loginPage.Close();
                var loginSuccessMessage = MessageBox.Avalonia.MessageBoxManager
    .GetMessageBoxStandardWindow("title", "User: " + UserName + " Logged in successfully");
                loginSuccessMessage.Show();
            }
            else
            {
                var loginFailedMessage = MessageBox.Avalonia.MessageBoxManager
    .GetMessageBoxStandardWindow("title", "Logged in failed");
                loginFailedMessage.Show();

            }
        }
    }
}
