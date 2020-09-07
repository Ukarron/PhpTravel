using System;

namespace PhpTravel.DTO
{
    public sealed class AdminDTO
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Email { set; get; }
        public string Password { set; get; }
        public string MobileNumber { set; get; }
        public string Country { set; get; }
        public string Address1 { set; get; }
        public string Address2 { set; get; }

        public AdminDTO(string firstName = null, string lastName = null, string email = null, string password = null,
            string country = null, string mobileNumber = null, string address1 = null, string address2 = null)
        {
            if (String.IsNullOrEmpty(firstName))
            {
                FirstName = GenerateFirstName();
            } 
            else
            {
                FirstName = firstName;
            }
            if (String.IsNullOrEmpty(lastName))
            {
                LastName = GenerateLastName();
            }
            else
            {
                LastName = lastName;
            }
            if (String.IsNullOrEmpty(email))
            {
                Email = GenerateEmail();
            }
            else
            {
                Email = email;
            }
            if (String.IsNullOrEmpty(password))
            {
                Password = GeneratePassword();
            }
            else
            {
                Password = password;
            }
            if (String.IsNullOrEmpty(country))
            {
                Country = GenerateCountry();
            }
            else
            {
                Country = country;
            }                
            if (String.IsNullOrEmpty(mobileNumber))
                MobileNumber = GenerateMobileNumber();
            if (String.IsNullOrEmpty(address1))
                Address1 = GenerateAddress1();
            if (String.IsNullOrEmpty(address2))
                Address2 = GenerateAddress2();
        }

        public string GenerateFirstName()
        {
            return Faker.Name.First();
        }

        public string GenerateLastName()
        {
            return Faker.Name.Last();
        }

        public string GenerateEmail()
        {
            return Faker.Internet.Email();
        }

        public string GeneratePassword()
        {
            return CodeBits.PasswordGenerator.Generate(8);
        }

        public string GenerateMobileNumber()
        {
            return Faker.Phone.Number();
        }

        public string GenerateCountry()
        {
            return Faker.Country.Name();
        }

        public string GenerateAddress1()
        {
            return Country + ", " + Faker.Address.StreetName();
        }

        public string GenerateAddress2()
        {
            return Country + ", " + Faker.Address.StreetName();
        }
    }
}
