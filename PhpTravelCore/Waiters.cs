using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace PhpTravel
{
    public sealed class Waiters
    {
        private IWebDriver _driver;
        private WebDriverWait _webDriverWait;
        private IJavaScriptExecutor _executor;
        private const int DEFAULT_WAIT_TIME = 20;

        public Waiters(IWebDriver driver)
        {
            this._driver = driver;
            _webDriverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(DEFAULT_WAIT_TIME));
        }

        public Waiters(IWebDriver driver, int waitTime)
        {
            this._driver = driver;
            _webDriverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(waitTime));
        }

        public void WaitForPageTitle(string pageTitle)
        {
            Wait.Until(d => d.Title.Equals(pageTitle));
        }

        public void WaitForElementIsVisible(By element)
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(element));
        }

        public void WaitForElementToBeClickable(By element)
        {
            Wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }

        public void WaitForElementExists(By element)
        {
            Wait.Until(ExpectedConditions.ElementExists(element));
        }

        public void WaitForElementToBeDisplayed(By element)
        {
            Wait.Until(d => _driver.FindElement(element).Displayed);
        }

        public void WaitForVisibleDisplayedClickable(By element)
        {
            WaitForElementIsVisible(element);
            WaitForElementToBeDisplayed(element);
            WaitForElementToBeClickable(element);
        }

        public void JustWait(int waitTime)
        {
            Thread.Sleep(waitTime);
        }

        public WebDriverWait Wait
        {
            get
            {
                if (_webDriverWait == null)
                {
                    _webDriverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(DEFAULT_WAIT_TIME));
                }
                return _webDriverWait;
            }
        }

        public IJavaScriptExecutor JavaScriptExecutor
        {
            get
            {
                if (_executor == null)
                {
                    _executor = (IJavaScriptExecutor)_driver;
                }
                return _executor;
            }
        }
    }
}
