using OpenQA.Selenium;
using PhpTravel.Pages.PagesComponents;
using PhpTravel.UIComponents;

namespace PhpTravel.Pages
{
    public abstract class AdminPage<T> : AbstractPage<T> where T : AdminPage_Selectors
    {
        public AdminPage(PhpTravelApp p, T type)
               : base(p, type) { }

        public virtual void EnterUsername(string email)
        {
            phpTravel.UIInteraction.EnterText(Selectors.EmailField, email);
        }

        public virtual void EnterPassword(string password)
        {
            phpTravel.UIInteraction.EnterText(Selectors.PasswordField, password);
        }

        public virtual void ClickLoginButton()
        {
            phpTravel.UIInteraction.Click(Selectors.LoginButton);
        }
    }

    public abstract class AdminPage_Selectors
    {
        public abstract By EmailField { get; }
        public abstract By PasswordField { get; }
        public abstract By LoginButton { get; }
    }
}
