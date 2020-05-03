using System;
using MyEmbraceDemo.Helpers;
using MyEmbraceDemo.ViewModels;
using MyEmbraceDemo.Views;
using Xamarin.Forms;

namespace MyEmbraceDemo
{

    public static class ViewModelLocator
    {

        static PetsViewModel petsVM;
        public static PetsViewModel PetsViewModel
        => petsVM ?? (petsVM = new PetsViewModel());

        static DetailsViewModel detailsVM;
        public static DetailsViewModel DetailsViewModel
        => detailsVM ?? (detailsVM = new DetailsViewModel(PetsHelper.Pets[0]));
    }

    public class App : Application
    {
        public App()
        {
            MainPage = new NavigationPage(new LoginPage())
            {
                BarTextColor = Color.White,
                BarBackgroundColor = Color.FromHex("#812990")
            };
        }



        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

