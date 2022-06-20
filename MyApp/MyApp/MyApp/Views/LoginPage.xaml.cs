using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MyApp.Views;
using MyApp.ViewModels;
using System.Text.RegularExpressions;
using MyApp.Utils;

namespace MyApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {

        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginPageViewModel(this);
        }

        public async void LoginButtonClicked(object sender, EventArgs e)
        {
            var email = Email.Text;
            var password = Password.Text;
            

            /*if (Regex.IsMatch(email,emailPattern))
            {
                if (email == "akosipeter@traxiontech.net" && password == "W3lc0m3!")
                {
                    await Navigation.PushAsync(new Dashboard());
                }
                else
                {
                    await DisplayAlert("Oops", "Account does not exist", "OK");
                }
            }
            else
            {
                await DisplayAlert("Oops", "Not a valid email account", "OK");
            }*/


            if (!string.IsNullOrWhiteSpace(email))
            {
                if (Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase)) 
                {

                    if (email == "akosipeter@traxiontech.net" && password == "W3lc0m3!")
                    {
                        await Navigation.PushAsync(new Dashboard());
                    }
                    else
                    {
                        await DisplayAlert("Oops", "Your username or password is wrong", "OK");
                        Email.Text = string.Empty;
                        Password.Text = string.Empty;
                    }
                }
                else
                {
                    await DisplayAlert("Oops", "Not a valid email account", "OK");
                    Email.Text = string.Empty;
                    Password.Text = string.Empty;
                }
            }
            else
            {
                await DisplayAlert("Oops", "Please input a value", "OK");
                Email.Text = string.Empty;
                Password.Text = string.Empty;
            }
            
        }


    }
}