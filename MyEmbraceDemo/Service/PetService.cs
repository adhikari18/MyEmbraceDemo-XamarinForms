using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using MyEmbraceDemo.Models;
using System.Linq;
using Xamarin.Forms;

namespace MyEmbraceDemo.Helpers
{
    public static class PetsHelper
    {

        private static Random random;

        public static Pet GetRandomPet()
        {
            return Pets[random.Next(0, Pets.Count)];
        }
                

        public static ObservableCollection<Pet> Pets { get; set; }
        static PetsHelper()
        {
            random = new Random();
            Pets = new ObservableCollection<Pet>();
            Pets.Add(new Pet
            {
                Name = "Fluffy",
                Age = "2",
                Sex = "Male",
                Species = "Dog",
                Breed = "Afghan Hound",
                Image = ImageSource.FromResource(string.Format("MyEmbraceDemo.Images.{0}", "afghanhound.jpg"))
            });

            Pets.Add(new Pet
            {
                Name = "Ginger",
                Age = "4",
                Sex = "Male",
                Species = "Dog",
                Breed = "Bulldog",
                Image = ImageSource.FromResource(string.Format("MyEmbraceDemo.Images.{0}", "bulldog.jpg"))
            });

            Pets.Add(new Pet
            {
                Name = "Jackie",
                Age = "3",
                Sex = "Male",
                Species = "Dog",
                Breed = "Tibetan Spaniel",
                Image = ImageSource.FromResource(string.Format("MyEmbraceDemo.Images.{0}", "tibetanspaniel.jpg"))
            });

        }
    }
}
