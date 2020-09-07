using OpenQA.Selenium;
using PhpTravel.Pages.PagesComponents;
using PhpTravel.UIComponents;
using System.Collections.Generic;
using System.Linq;

namespace PhpTravel.Pages.Admin
{
    public class AdminsManagementGrid : AbstractPage<AdminsManagementGrid_Selectors>
    {
        public AdminsManagementGrid(PhpTravelApp p) 
            : base(p, new AdminsManagementGrid_Selectors()) { }

        public Admin GetAdmin(string email)
        {
            var list = new List<Admin>();

            var hotelsList = phpTravel.Driver.FindElements(Selectors.Admins);

            foreach (var hotel in hotelsList)
            {
                list.Add(new Admin(hotel));
            }

            var admin = list.Single(x => x.Email == email);

            return admin;
        }
    }

    public class AdminsManagementGrid_Selectors
    {
        public readonly By Admins = By.CssSelector(".xcrud-list-container tr.xcrud-row");
    }

    public class Admin
    {
        private IWebElement _rootelement;
        public readonly By FirstNameElement = By.CssSelector("td:nth-of-type(3)");
        public readonly By LastNameElement = By.CssSelector("td:nth-of-type(4)");
        public readonly By EmailElement = By.CssSelector("td:nth-of-type(5)");

        public string FirstName { get; }
        public string LastName { get; }
        public string Email { get; }

        public Admin(IWebElement rootelement)
        {
            this._rootelement = rootelement;
            FirstName = _rootelement.FindElement(FirstNameElement).Text;
            LastName = _rootelement.FindElement(LastNameElement).Text;
            Email = _rootelement.FindElement(EmailElement).Text;
        }
    }
}