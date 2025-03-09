using SignupApp.Pages;

namespace SignupApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Register routes for navigation
            Routing.RegisterRoute("signup", typeof(SignupPage));
            Routing.RegisterRoute("profile", typeof(ProfilePage));
        }
    }
    }

