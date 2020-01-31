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
            app.Navigator.GoToHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Contacts.InitNewContactCreation();
            ContactData contact = new ContactData("Frida");
            contact.Firstname = "Frida";
            contact.Lastname = "Kahlo";
            app.Contacts.FillContactForm(contact);
            app.Contacts.SubmitContactCreation();
            app.Navigator.ReturnToHomePage();
            app.Navigator.Logout();
        }
    }
}

