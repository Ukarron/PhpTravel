using OpenQA.Selenium;
using PhpTravel.FrameworkComponents;
using PhpTravel.UIComponents;
using System.Configuration;

namespace PhpTravel.Pages.Admin
{
    public class AdminLoginPage : AdminPage<AdminLoginPage_Selectors>
    {
        public AdminLoginPage(PhpTravelApp p)
            : base(p, new AdminLoginPage_Selectors()) { }

        public virtual void LoginAsAdmin(string url = null)
        {
            if (url == null)
            {
                phpTravel.UrlManager.OpenUrl(RunConfiguration.Url);
            }
            else
            {
                phpTravel.UrlManager.OpenUrl(url);
            }

            EnterUsername(ConfigurationManager.AppSettings["EmailAdmin"]);
            EnterPassword(ConfigurationManager.AppSettings["PasswordAdmin"]);

            ClickLoginButton();
        }
    }

    public class AdminLoginPage_Selectors : AdminPage_Selectors
    {
        public override By EmailField => By.CssSelector(".form-signin [placeholder='Email']");
        public override By PasswordField => By.CssSelector(".form-signin [placeholder='Password']");
        public override By LoginButton => By.CssSelector("button[type='submit']");
    }
}
