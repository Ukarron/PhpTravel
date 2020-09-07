using NUnit.Framework;
using PhpTravel.FrameworkComponents;
using System;

namespace PhpTravelTests.Exercises
{
    [TestFixture]
    [Parallelizable]
    public class Exercise1 : BaseTest
    {
        private readonly string expectedDate = DateTime.Today.ToString("d MMMM yyyy");

        [Test, Description("Verifies that the date after login is a current date and finds the cheapest hotel on the Home page.")]
        public void Exercise1Test()
        {
            PhpTravel.LoginPage.LoginAsDemoUser();

            var actualDate = PhpTravel.AccountPage.GetCurrentDateText();

            Assert.AreEqual(expectedDate, actualDate, "FAIL: Expected and actual date are different!");

            PhpTravel.UrlManager.OpenUrl(UrlManager.HomePageUrl);

            var expectedTheCheapestFeaturedHotel = 20;
            var actualTheCheapestFeaturedHotel = PhpTravel.HomePage.FeaturedHotelsGrid.GetTheCheapestHotel().Price;

            Assert.AreEqual(expectedTheCheapestFeaturedHotel, actualTheCheapestFeaturedHotel);
        }
    }
}
