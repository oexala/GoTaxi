using MyApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MyApp
{
    public class SplashScreen : ContentPage
    {
        Image splashImage;
        public SplashScreen()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            var sub = new AbsoluteLayout();
            splashImage = new Image
            {
                Source = "splashscreen",
                WidthRequest = 1080,
                HeightRequest = 2030
            };
            AbsoluteLayout.SetLayoutFlags(splashImage, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(splashImage, new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
            sub.Children.Add(splashImage);
            this.BackgroundColor = Color.FromHex("#G12234");
            this.Content = sub;
        }
            protected override async void OnAppearing()
            {
                base.OnAppearing();

                await splashImage.ScaleTo(1, 2000);
                await splashImage.ScaleTo(0.9, 1500, Easing.Linear);
                await splashImage.ScaleTo(150, 1200, Easing.Linear);
                Application.Current.MainPage = new NavigationPage(new LoginPage());

            }

        
    }
}