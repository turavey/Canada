using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    public class ContactHelper : HelperBase
    { 
        public ContactHelper(ApplicationManager manager) : base(manager)
        { 
        }

        public ContactHelper RemoveContact(string v)
        {
            manager.Navigator.OpenContactsPage();
            SelectContact(v);
            RemoveContact();
            manager.Navigator.ReturnToContactPage();
            return this;
        }

        public ContactHelper Modify(ContactData newData)
        {
            manager.Navigator.OpenContactsPage();
            InitContactModification();
            FillContactForm(newData);
            SubmitContactModification();
            manager.Navigator.ReturnToContactPage();


            return this;
        }

 

        public ContactHelper CreateContact(ContactData contact)
        {
            manager.Navigator.ReturnToContactPage();
            InitNewContactCreation();
            FillContactForm(contact);
            SubmitContactCreation();
            return this;
        }

        public ContactHelper SubmitContactCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;
        }

        public ContactHelper FillContactForm(ContactData contact)
        {
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(contact.Firstname);
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys(contact.Lastname);
            return this;
        }

        public ContactHelper InitNewContactCreation()
        {
            driver.FindElement(By.LinkText("add new")).Click();
            return this;
        }
        public ContactHelper SelectContact(string id)
        {
            driver.FindElement(By.Id(id)).Click();
            return this;
        }
        public ContactHelper RemoveContact()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            driver.SwitchTo().Alert().Accept();
            return this;
        }
        public ContactHelper SubmitContactModification()
        {
            driver.FindElement(By.Name("update")).Click();
            return this;
        }

        public ContactHelper InitContactModification()
        {
            driver.FindElement(By.CssSelector("img[alt=\"Edit\"]")).Click(); 
            return this;
        }
    }
}
