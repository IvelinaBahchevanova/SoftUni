using Homework3;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Reflection;
using static com.sun.org.apache.xerces.@internal.impl.XMLDocumentFragmentScannerImpl;

namespace Homework3
{
    [TestFixture]
    public class POMTests : BaseTest
    {
        private LoginPage _loginPage;
        private RegistrationPage _regPage;
        private RegistrationUser _user;

        [SetUp]
        public void CalssInit()
        {
            _loginPage = new LoginPage(Driver);
            _regPage = new RegistrationPage(Driver);

            _user = UserFactory.CreateValidUser();

        }


        [Test]

        public void AutomationpracticeRegistration()
        {

            _regPage.Navigate(_loginPage);
            _regPage.AssertPageHeader("CREATE AN ACCOUNT");

        }

        [Test]

        public void FillRegistrationFormWithoutFirstName()
        {
            _user.CustomerFirstName = "";

            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);

            _regPage.AssertErrorMessage("firstname is required.");
        }

        [Test]
        public void FillRegistrationFormWithoutLastName()
        {
            _user.CustomerLastName = "";

            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);

            _regPage.AssertErrorMessage("lastname is required.");
        }

        [Test]
        public void FillRegistrationFormWithoutDate()
        {
            _user.Date = "";

            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);

            _regPage.AssertErrorMessage("Invalid date of birth");
        }

        [Test]
        public void FillRegistrationFormWithoutPassword()
        {
            _user.Password = "";

            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);

            _regPage.AssertErrorMessage("passwd is required.");
        }

        [Test]
        public void FillRegistrationFormWithoutCity()
        {
            _user.Password = "";

            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);

            _regPage.AssertErrorMessage("city is required.");
        }
    }
}
