namespace DoorDashClone;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        // Register routes for navigation
        Routing.RegisterRoute(nameof(Views.HomePage), typeof(Views.HomePage));
        Routing.RegisterRoute(nameof(Views.SearchPage), typeof(Views.SearchPage));
        Routing.RegisterRoute(nameof(Views.OrdersPage), typeof(Views.OrdersPage));
        Routing.RegisterRoute(nameof(Views.AccountPage), typeof(Views.AccountPage));
    }
}