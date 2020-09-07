using OpenQA.Selenium;
using PhpTravel.Pages.PagesComponents;
using PhpTravel.UIComponents;

namespace PhpTravel.Pages.Admin
{
    public class AdminsManagementPage : AbstractPage<AdminsManagementPage_Selectors>
    {
        private const string Page_Title = "Admins Management";

        private AdminsManagementGrid _adminsManagementGrid;

        public AdminsManagementGrid AdminsManagementGrid => _adminsManagementGrid ?? (_adminsManagementGrid = new AdminsManagementGrid(this.phpTravel));

        public AdminsManagementPage(PhpTravelApp p) 
            : base(p, new AdminsManagementPage_Selectors()) { }

        public void ClickAddButton()
        {
            phpTravel.Waiter.WaitForPageTitle(Page_Title);
            phpTravel.UIInteraction.Click(Selectors.AddButton);
        }
    }

    public class AdminsManagementPage_Selectors
    {
        public readonly By AddButton = By.XPath("//button[@type='submit']");
    }
}