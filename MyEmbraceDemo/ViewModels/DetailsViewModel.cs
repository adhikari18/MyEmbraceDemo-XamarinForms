using System;
using MyEmbraceDemo.Models;

namespace MyEmbraceDemo.ViewModels
{
    public class DetailsViewModel
    {
        public Pet Pet { get; set; }
        public DetailsViewModel(Pet pet)
        {
            Pet = pet;
        }
    }
}

