using OpenQA.Selenium;
using PhpTravel.FrameworkComponents;

namespace PhpTravel.UIComponents
{
    public partial class PhpTravelApp
    {
        private IWebDriver _driver;
        private UrlManager _urlManager;
        private UIInteraction _uiInteraction;
        private Waiters _waiter;

        public PhpTravelApp(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebDriver Driver => _driver;

        public UrlManager UrlManager => _urlManager ?? (_urlManager = new UrlManager(Driver));
        public UIInteraction UIInteraction => _uiInteraction ?? (_uiInteraction = new UIInteraction(Driver));
        public Waiters Waiter => _waiter ?? (_waiter = new Waiters(Driver));
    }
}
