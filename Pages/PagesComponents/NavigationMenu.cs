using OpenQA.Selenium;
using PhpTravel.Pages.Admin;
using PhpTravel.UIComponents;

namespace PhpTravel.Pages.PagesComponents
{
    public class NavigationMenu : AbstractPage<NavigationMenu_Selectors>
    {
        public NavigationMenu(PhpTravelApp p) 
            : base(p, new NavigationMenu_Selectors()) {}

        public void ExpandSectionAndSelectSubsection(Section section, AccountsSubsection subsection)
        {
            ExpandSection(section);
            ExpandSubsection(subsection);
        }

        public void ExpandSection(Section section)
        {
            switch (section)
            {
                case Section.ACCOUNTS:
                    phpTravel.UIInteraction.Click(Selectors.AccountsSection);
                    break;
            }
        }

        public void ExpandSubsection(AccountsSubsection subsection)
        {
            switch (subsection)
            {
                case AccountsSubsection.ADMINS:
                    phpTravel.UIInteraction.Click(Selectors.AdminSubsection);
                    break;
            }
        }
    }

    public class NavigationMenu_Selectors
    {
        public readonly By AccountsSection = By.CssSelector("[href='#ACCOUNTS']");
        public readonly By AdminSubsection = By.CssSelector("[href='https://www.phptravels.net/admin/accounts/admins/']");
    }
}
