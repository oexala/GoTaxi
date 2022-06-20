using MyApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyApp.ViewModels
{
    public class LoginPageViewModel : INotifyPropertyChanged
    {
        public string Email;
        public string Password;
        LoginPage loginPage;
        public string Title;
        public LoginPageViewModel(LoginPage loginpage)
        {
            Email = "akosipeter@traxiontech.net";
            Password = "W3lc0m3!";
            this.loginPage = loginpage;
        }
        #region INotifyPropertyChanged implementation
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        


        

    }

}
