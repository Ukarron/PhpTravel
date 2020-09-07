using OpenQA.Selenium;

namespace PhpTravel.FrameworkComponents
{
    public class UrlManager
    {
        private IWebDriver _driver;

        public UrlManager(IWebDriver driver)
        {
            _driver = driver;
        }

        public void OpenUrl(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public static string AdminLoginPageUrl => "https://www.phptravels.net/admin";
        public static string AdminPageUrl => "https://www.phptravels.net/admin";
        public static string HomePageUrl =>  "https://www.phptravels.net/home";        
    }
}
