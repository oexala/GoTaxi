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
    public partial class LoginPageView : ContentPage
    {

        public LoginPageView()
        {
            InitializeComponent();
            BindingContext = new LoginPageViewModel();
   
        }

        


    }
}