using NUnit.Framework;
using PhpTravel.FrameworkComponents;
using PhpTravel.Pages.Admin;
using PhpTravel.DTO;

namespace PhpTravelTests.Exercises
{
    [TestFixture]
    [Parallelizable]
    public class Exercise2 : BaseTest
    {
        private readonly AdminDTO newAdmin = new AdminDTO(country: "United States");

        [Test, Description("Creates new user and verifies that user was created correctly.")]
        public void Exercise2Test()
        {
            PhpTravel.AdminLoginPage.LoginAsAdmin(UrlManager.AdminLoginPageUrl);

            PhpTravel.NavigationMenu.ExpandSectionAndSelectSubsection(Section.ACCOUNTS, AccountsSubsection.ADMINS);

            PhpTravel.AdminsManagementPage.ClickAddButton();

            PhpTravel.AddAdminPage.AddNewAdmin(newAdmin);

            var admin = PhpTravel.AdminsManagementPage.AdminsManagementGrid.GetAdmin(newAdmin.Email);

            var actualFirstName = admin.FirstName;
            var actualLastName = admin.LastName;
            var actualEmail = admin.Email;

            Assert.AreEqual(newAdmin.FirstName, actualFirstName);
            Assert.AreEqual(newAdmin.LastName, actualLastName);
            Assert.AreEqual(newAdmin.Email, actualEmail);
        }
    }
}