using OpenQA.Selenium;
using PhpTravel.Pages.PagesComponents;
using PhpTravel.UIComponents;

namespace PhpTravel.Pages.HomePage
{
    public class HomePage : AbstractPage<HomePage_Selectors>
    {
        private FeaturedHotelsGrid _featuredHotelsGrid;

        public FeaturedHotelsGrid FeaturedHotelsGrid => _featuredHotelsGrid ?? (_featuredHotelsGrid = new FeaturedHotelsGrid(phpTravel));

        public HomePage(PhpTravelApp p)
               : base(p, new HomePage_Selectors()) { }

        public HomePage ExpandMyAccountDropDown()
        {
            phpTravel.UIInteraction.Click(Selectors.MyAccountDropDown);
            return this;
        }

        public HomePage ClickLoginLink()
        {
            phpTravel.UIInteraction.Click(Selectors.LoginLink);
            return this;
        }

        public HomePage ClickSignUpLink()
        {
            phpTravel.UIInteraction.Click(Selectors.SignUpLink);
            return this;
        }
    }

    public class HomePage_Selectors
    {
        public readonly By MyAccountDropDown = By.CssSelector(".dropdown.dropdown-login #dropdownCurrency");
        public readonly By LoginLink = By.LinkText("Login");
        public readonly By SignUpLink = By.LinkText("Register");
    }
}
