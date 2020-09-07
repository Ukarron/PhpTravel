using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using PhpTravel.FrameworkComponents;

namespace PhpTravel
{
    public sealed class Browser
    {
        private IWebDriver _driver;

        public IWebDriver Driver
        {
            get
            {
                if (_driver == null)
                {
                    _driver = StartBrowser();
                }
                return _driver;
            }
        }

        public IWebDriver StartBrowser()
        {
            var browser = RunConfiguration.Browser;

            switch (browser)
            {
                case "Chrome":
                    _driver = new ChromeDriver();
                    break;

                case "Firefox":
                    _driver = new FirefoxDriver();
                    break;

                case "IE":
                    _driver = new InternetExplorerDriver();
                    break;

                default:
                    _driver = new ChromeDriver();
                    break;
            }
            _driver.Manage().Window.Maximize();

            return _driver;
        }

        public void CloseBrowser()
        {
            _driver.Quit();
            _driver = null;
        }
    }
}
