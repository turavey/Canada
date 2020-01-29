using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {

        [Test]
        public void ContactCreationTest()
        {
            navigator.GoToHomePage();
            loginHelper.Login(new AccountData("admin", "secret"));
            contactHelper.InitNewContactCreation();
            ContactData contact = new ContactData("Frida");
            contact.Firstname = "Frida";
            contact.Lastname = "Kahlo";
            contactHelper.FillContactForm(contact);
            contactHelper.SubmitContactCreation();
            navigator.ReturnToHomePage();
            navigator.Logout();
        }
    }
}

