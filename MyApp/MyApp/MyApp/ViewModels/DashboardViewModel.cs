using MyApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MyApp.ViewModels
{
    public class DashboardViewModel
    {
        public DashboardViewModel()
        {
            LogoutButtonClicked = new Command(Logout);
        }
        public Command LogoutButtonClicked { get; }
        public async void Logout()
        {

            await Application.Current.MainPage.Navigation.PushAsync(new LoginPageView());

        }
    }



}
