using OpenQA.Selenium;
using PhpTravel.DTO;
using PhpTravel.Pages.PagesComponents;
using PhpTravel.UIComponents;

namespace PhpTravel.Pages.Admin
{
    public class AddAdminPage : AbstractPage<AddAdminPage_Selectors>
    {
        public AddAdminPage(PhpTravelApp p) 
            : base(p, new AddAdminPage_Selectors()) { }

        public void AddNewAdmin(AdminDTO admin)
        {
            EnterFirstName(admin.FirstName)
                .EnterLastName(admin.LastName)
                .EnterEmail(admin.Email)
                .EnterPassword(admin.Password)
                .EnterMobileNumber(admin.MobileNumber)
                .SelectCountry(admin.Country)
                .EnterAddress1(admin.Address1)
                .EnterAddress2(admin.Address2)
                .CheckEmailNewsletterSubscriberCheckbox()
                .CheckHotelsCheckbox()
                .CheckToursCheckbox()
                .CheckLocationsCheckbox()
                .ClickSubmit();
        }

        public AddAdminPage EnterFirstName(string firstName)
        {
            phpTravel.UIInteraction.EnterText(Selectors.FirstNameField, firstName);
            return this;
        }

        public AddAdminPage EnterLastName(string lastName)
        {
            phpTravel.UIInteraction.EnterText(Selectors.LastNameField, lastName);
            return this;
        }

        public AddAdminPage EnterEmail(string email)
        {
            phpTravel.UIInteraction.EnterText(Selectors.EmailField, email);
            return this;
        }

        public AddAdminPage EnterPassword(string password)
        {
            phpTravel.UIInteraction.EnterText(Selectors.PasswordField, password);
            return this;
        }

        public AddAdminPage EnterMobileNumber(string mobileNumber)
        {
            phpTravel.UIInteraction.EnterText(Selectors.MobileNumberField, mobileNumber);
            return this;
        }

        public AddAdminPage SelectCountry(string country)
        {
            ExpandCountryDropDown();
            ClickCountry(country);
            return this;
        }

        private void ExpandCountryDropDown()
        {
            phpTravel.UIInteraction.Click(Selectors.CountryDropDown);
        }

        private void ClickCountry(string country)
        {
            phpTravel.UIInteraction.Click(Selectors.GetCountry(country));
        }

        public AddAdminPage EnterAddress1(string address1)
        {
            phpTravel.UIInteraction.EnterText(Selectors.Address1Field, address1);
            return this;
        }

        public AddAdminPage EnterAddress2(string address2)
        {
            phpTravel.UIInteraction.EnterText(Selectors.Address2Field, address2);
            return this;
        }

        public AddAdminPage CheckEmailNewsletterSubscriberCheckbox()
        {
            phpTravel.UIInteraction.Click(Selectors.EmailNewsletterSubscriberCheckbox);
            return this;
        }

        public AddAdminPage CheckHotelsCheckbox()
        {
            phpTravel.UIInteraction.Click(Selectors.HotelsCheckbox);
            return this;
        }

        public AddAdminPage CheckToursCheckbox()
        {
            phpTravel.UIInteraction.Click(Selectors.ToursCheckbox);
            return this;
        }

        public AddAdminPage CheckLocationsCheckbox()
        {
            phpTravel.UIInteraction.Click(Selectors.LocationsCheckbox);
            return this;
        }

        public AddAdminPage ClickSubmit()
        {
            phpTravel.UIInteraction.Click(Selectors.SubmitButton);
            return this;
        }
    }

    public class AddAdminPage_Selectors
    {
        //Add Admin section
        public readonly By FirstNameField = By.XPath("//input[@placeholder='First name']");
        public readonly By LastNameField = By.XPath("//input[@placeholder='Last name']");
        public readonly By EmailField = By.XPath("//input[@placeholder='Email address']");
        public readonly By PasswordField = By.XPath("//input[@placeholder='Password']");
        public readonly By MobileNumberField = By.XPath("//input[@placeholder='Mobile Number']");
        public readonly By CountryDropDown = By.XPath("//*[@class='select2-chosen']");
        public readonly By Address1Field = By.XPath("//input[@name='address1']");
        public readonly By Address2Field = By.XPath("//input[@name='address2']");
        public readonly By EmailNewsletterSubscriberCheckbox = By.XPath("//*[@name='newssub']");
        public readonly By SubmitButton = By.CssSelector("button.btn.btn-primary");

        public By GetCountry(string country) => By.XPath($"//div[text()='{country}']");

        //MAIN SETTINGS section
        //ADD section
        public readonly By HotelsCheckbox = By.XPath("//*[@value='addHotels']");
        public readonly By ToursCheckbox = By.XPath("//*[@value='addTours']");
        public readonly By LocationsCheckbox = By.XPath("//*[@value='addlocations']");
    }
}
