using NUnit.Framework;
using PhpTravel;
using PhpTravel.UIComponents;

namespace PhpTravelTests
{
    [SetUpFixture]
    public abstract class BaseTest
    {
        private PhpTravelApp _phpTravelApp;
        private Browser _browser = new Browser();

        protected PhpTravelApp PhpTravel => _phpTravelApp ?? (_phpTravelApp = new PhpTravelApp(_browser.Driver));

        [OneTimeTearDown]
        public void TearDownTest()
        {
            _browser.CloseBrowser();
        }
    }
}
