using PhpTravel.UIComponents;

namespace PhpTravel.Pages.PagesComponents
{
    public class AbstractPage<T>
    {
        protected PhpTravelApp phpTravel;
        private T _selectors;

        public AbstractPage(PhpTravelApp a, T type)
        {
            phpTravel = a;
            _selectors = type;
        }

        public T Selectors
        {
            get { return _selectors; }
        }
    }
}
