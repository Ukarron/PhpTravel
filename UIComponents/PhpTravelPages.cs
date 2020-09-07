using PhpTravel.Pages.AccountPage;
using PhpTravel.Pages.Admin;
using PhpTravel.Pages.HomePage;
using PhpTravel.Pages.LoginPage;
using PhpTravel.Pages.PagesComponents;

namespace PhpTravel.UIComponents
{
    public partial class PhpTravelApp
    {
        private AddAdminPage _addAdminPage;
        private AdminLoginPage _adminLoginPage;
        private AccountPage _accountPage;
        private AdminsManagementPage adminsManagementPage;
        private HomePage _homePage;
        private LoginPage _loginPage;
        private NavigationMenu navigationMenu;

        public AddAdminPage AddAdminPage => _addAdminPage ?? (_addAdminPage = new AddAdminPage(this));
        public AdminLoginPage AdminLoginPage => _adminLoginPage ?? (_adminLoginPage = new AdminLoginPage(this));
        public AccountPage AccountPage => _accountPage ?? (_accountPage = new AccountPage(this));
        public AdminsManagementPage AdminsManagementPage => adminsManagementPage ?? (adminsManagementPage = new AdminsManagementPage(this));
        public HomePage HomePage => _homePage ?? (_homePage = new HomePage(this));
        public LoginPage LoginPage => _loginPage ?? (_loginPage = new LoginPage(this));
        public NavigationMenu NavigationMenu => navigationMenu ?? (navigationMenu = new NavigationMenu(this));
    }
}
