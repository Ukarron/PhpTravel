using OpenQA.Selenium;
using PhpTravel.Pages.PagesComponents;
using PhpTravel.UIComponents;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PhpTravel.Pages.HomePage
{
    public class FeaturedHotelsGrid : AbstractPage<FeaturedHotelsGrid_Selectors>
    {
        private List<Hotel> _featuredHotels = new List<Hotel>();

        public FeaturedHotelsGrid(PhpTravelApp p)
            : base(p, new FeaturedHotelsGrid_Selectors()) { }

        public Hotel GetTheCheapestHotel()
        {
            _featuredHotels = GetAllFeaturedHotels();

            var theCheapestFeaturedHotel = _featuredHotels.Min();

            return theCheapestFeaturedHotel;
        }

        private List<Hotel> GetAllFeaturedHotels()
        {
            var list = new List<Hotel>();

            var hotelsList = phpTravel.Driver.FindElements(Selectors.Hotels);

            foreach (var hotel in hotelsList)
            {
                list.Add(new Hotel(hotel));
            }

            return list;
        }
    }

    public class FeaturedHotelsGrid_Selectors
    {
        public readonly By Hotels = By.XPath("//*[@class='col-lg-3 col-sm-4 col-xs-12']");
    }

    public class Hotel : IComparable
    {
        private IWebElement _rootElement;
        private readonly By NameElement = By.XPath(".//*[@class='float-none']");
        private readonly By PriceElement = By.XPath(".//*[@class='price']//span");

        public string Name { get; }
        public int Price { get; }

        public Hotel(IWebElement rootElement)
        {
            _rootElement = rootElement;
            Name = _rootElement.FindElement(NameElement).Text;
            Price = int.Parse(_rootElement.FindElement(PriceElement).Text.Substring(1));
        }

        public int CompareTo(object obj)
        {
            if (Price < ((Hotel)obj).Price)
            {
                return -1;
            }
            else if (Price > ((Hotel)obj).Price)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}