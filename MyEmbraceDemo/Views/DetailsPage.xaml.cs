using System;
using System.Collections.Generic;
using MyEmbraceDemo.Models;
using Xamarin.Forms;
using MyEmbraceDemo.ViewModels;

namespace MyEmbraceDemo.Views
{
    public partial class DetailsPage : ContentPage
    {
        public DetailsPage(Pet pet)
        {
            InitializeComponent();
            BindingContext = new DetailsViewModel(pet);
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SubmitClaimDocsPage());
        }
    }
}

