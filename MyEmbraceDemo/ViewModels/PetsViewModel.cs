using MyEmbraceDemo.Helpers;
using MyEmbraceDemo.Models;
using System.Collections.ObjectModel;
using System.Linq;

namespace MyEmbraceDemo.ViewModels
{
    public class PetsViewModel
    {
        public ObservableCollection<Pet> Pets { get; set; }

        public PetsViewModel()
        {

            Pets = PetsHelper.Pets;
        }

        public int PetCount => Pets.Count;
    }
}
