using MyApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
[assembly: ExportFont("Asap-Medium.otf" ,Alias = "Asap" ) ]
namespace MyApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPageView());
        }
        
        protected override void OnStart()
        {
        }








        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }

}
