using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MyEmbraceDemo.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();

        }

        async void ButtonLoginClicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new PetsPage());
        }
    }
}

