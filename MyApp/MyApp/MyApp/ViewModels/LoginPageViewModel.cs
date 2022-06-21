using System.Text.RegularExpressions;
using Xamarin.Forms;
using MyApp.Views;

namespace MyApp.ViewModels
{
    public class LoginPageViewModel 
    {
        private string email;
        private string password;
        public LoginPageViewModel()
        {
            LoginButtonClicked = new Command(Login);
        }
        
        public string Email { get { return email; } set { email = value; } }
        public string Password { get { return password; } set { password = value; } }

        public Command LoginButtonClicked { get; }

        private async void Login()
        {
            if (!string.IsNullOrWhiteSpace(email))
            {
                if (Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
                {

                    if (email == "akosipeter@traxiontech.net" && password == "W3lc0m3!")
                    {
                        await Application.Current.MainPage.Navigation.PushAsync(new DashboardView());
                    }
                    else
                    {
                        await Application.Current.MainPage.DisplayAlert("Oops", "Your username or password is wrong", "OK");
                        //Email.Text = string.Empty;
                        //Password.Text = string.Empty;
                    }
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Oops", "Not a valid email account", "OK");
                    //Email.Text = string.Empty;
                    //Password.Text = string.Empty;
                }
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Oops", "Please input a value", "OK");
                //Email.Text = string.Empty;
                //Password.Text = string.Empty;
            }

        }





    }

}
