using DoorDashClone.ViewModels;

namespace DoorDashClone.Views
{
    public partial class HomePage : ContentPage
    {
        private HomeViewModel _viewModel;

        public HomePage()
        {
            InitializeComponent();
            _viewModel = new HomeViewModel();
            BindingContext = _viewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            // For debugging
            if (_viewModel.Restaurants != null)
            {
                System.Diagnostics.Debug.WriteLine($"Restaurant Count: {_viewModel.Restaurants.Count}");
                foreach (var restaurant in _viewModel.Restaurants)
                {
                    System.Diagnostics.Debug.WriteLine($"Restaurant: {restaurant.Name}");
                }
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Restaurants collection is null");
            }
        }
    }
}