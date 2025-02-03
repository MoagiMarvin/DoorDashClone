using System.Collections.ObjectModel;
using DoorDashClone.Models;

namespace DoorDashClone.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        private ObservableCollection<Restaurant> _restaurants;
        private bool _isLoading;
        private string _selectedCategory;

        public ObservableCollection<Restaurant> Restaurants
        {
            get => _restaurants;
            set => SetProperty(ref _restaurants, value);
        }

        public bool IsLoading
        {
            get => _isLoading;
            set => SetProperty(ref _isLoading, value);
        }

        public string SelectedCategory
        {
            get => _selectedCategory;
            set
            {
                if (SetProperty(ref _selectedCategory, value))
                {
                    FilterRestaurants();
                }
            }
        }

        public HomeViewModel()
        {
            LoadRestaurants();
        }

        private void LoadRestaurants()
        {
            IsLoading = true;

            // Sample data
            Restaurants = new ObservableCollection<Restaurant>
            {
                new Restaurant
                {
                    Id = "1",
                    Name = "Burger King",
                    Description = "Fast Food • Burgers • American",
                    ImageUrl = "burger_king.png",
                    Rating = 4.5,
                    DeliveryTime = "20-30 min",
                    DeliveryFee = "$2.99",
                    Categories = new List<string> { "Fast Food", "Burgers" }
                },
                new Restaurant
                {
                    Id = "2",
                    Name = "Sushi Express",
                    Description = "Japanese • Sushi • Asian",
                    ImageUrl = "sushi_express.png",
                    Rating = 4.7,
                    DeliveryTime = "25-35 min",
                    DeliveryFee = "$3.99",
                    Categories = new List<string> { "Sushi", "Japanese" }
                },
                // Add more sample restaurants as needed
            };

            IsLoading = false;
        }

        private void FilterRestaurants()
        {
            if (string.IsNullOrEmpty(SelectedCategory))
            {
                LoadRestaurants();
                return;
            }

            var filteredRestaurants = _restaurants.Where(r =>
                r.Categories.Contains(SelectedCategory, StringComparer.OrdinalIgnoreCase));

            Restaurants = new ObservableCollection<Restaurant>(filteredRestaurants);
        }
    }
}