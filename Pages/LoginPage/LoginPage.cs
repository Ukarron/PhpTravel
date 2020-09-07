using OpenQA.Selenium;
using PhpTravel.FrameworkComponents;
using PhpTravel.UIComponents;
using System.Configuration;

namespace PhpTravel.Pages.LoginPage
{
    public class LoginPage : AdminPage<LoginPage_Selectors>
    {
        public LoginPage(PhpTravelApp p)
            : base(p, new LoginPage_Selectors()) { }

        public void LoginAsDemoUser(string url = null)
        {
            if (url == null)
            {
                phpTravel.UrlManager.OpenUrl(RunConfiguration.Url);
            }
            else
            {
                phpTravel.UrlManager.OpenUrl(url);
            }

            phpTravel.HomePage.ExpandMyAccountDropDown();
            phpTravel.HomePage.ClickLoginLink();

            EnterUsername(ConfigurationManager.AppSettings["EmailDemoUser"]);
            EnterPassword(ConfigurationManager.AppSettings["PasswordDemoUser"]);

            ClickLoginButton();
        }
    }

    public class LoginPage_Selectors : AdminPage_Selectors
    {
        public override By EmailField => By.Name("username");
        public override By PasswordField => By.Name("password");
        public override By LoginButton => By.XPath("//button[text()='Login']");
    }
}
