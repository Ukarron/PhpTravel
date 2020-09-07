using OpenQA.Selenium;
using PhpTravel.Pages.PagesComponents;
using PhpTravel.UIComponents;

namespace PhpTravel.Pages.AccountPage
{
    public class AccountPage : AbstractPage<AccountPage_Selectors>
    {
        public AccountPage(PhpTravelApp p)
            : base(p, new AccountPage_Selectors()) { }

        public string GetCurrentDateText()
        {
            return phpTravel.UIInteraction.GetText(Selectors.CurrentDateText);
        }
    }

    public class AccountPage_Selectors
    {
        public readonly By CurrentDateText = By.ClassName("h4");
    }
}
