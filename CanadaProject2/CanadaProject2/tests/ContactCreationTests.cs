﻿using System;
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
 
            ContactData contact = new ContactData("Bob");
            contact.Lastname = "Head";
            app.Contacts.CreateContact(contact);
        }
        [Test]
        public void EmptyContactCreationTest()
        {

            ContactData contact = new ContactData("");
            contact.Lastname = "";

            app.Contacts.CreateContact(contact);
        }
    }
}
