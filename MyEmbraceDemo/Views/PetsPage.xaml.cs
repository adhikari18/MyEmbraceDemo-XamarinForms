using System;
using System.Collections.Generic;
using MyEmbraceDemo.ViewModels;
using Xamarin.Forms;
using MyEmbraceDemo.Models;

namespace MyEmbraceDemo.Views
{
    public partial class PetsPage : ContentPage
    {
        public PetsPage()
        {
            InitializeComponent();
            BindingContext = new PetsViewModel();
        }

         void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //var pet = ((ListView)sender).SelectedItem as Pet;
            //if (pet == null)
            //    return;

            //await Navigation.PushAsync(new DetailsPage(pet));
        }

        async private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var pet = e.Item as Pet;// ((ListView)sender).SelectedItem as Pet;
            if (pet == null)
                return;

            await Navigation.PushAsync(new DetailsPage(pet));
            ((ListView)sender).SelectedItem = null;
        }
    }
}

