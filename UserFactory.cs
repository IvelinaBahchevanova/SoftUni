using System;
using System.Collections.Generic;
using System.Text;

namespace Homework3
{
    public static class UserFactory
    {
        public static RegistrationUser CreateValidUser()
        {
            return new RegistrationUser
            {
                CustomerFirstName = "Ivelina",
                CustomerLastName = "Bahchevanova",
                Password = "123456",
                Date = "4",
                Month = "5",
                Year = "2009",
                FirstName = "Ivelina",
                LastName = "Bahchevanova",
                Address = "Bulgaria",
                City = "Sofia",
                State = "Arizona",
                PostCode = "85000",
                Phone = "0888123456",
                Alias = "Home",

            };
        }
    }
}
