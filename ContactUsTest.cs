using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace PlanitWebTest
{
    class ContactUsTest
    {
        [Test]
        public void StartApplication()

        {
            using (IWebDriver driver = new ChromeDriver())
            {

                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://www.planittesting.com/nz/Contact");
                string errormessage;

                IWebElement firstname =
                    driver.FindElement(By.Id("p_lt_ctl03_pageplaceholder_p_lt_ctl01_ContactForm_viewBiz_FirstName_txtText"));

                firstname.SendKeys("Lance");

                IWebElement lastName =
                    driver.FindElement(By.Id("p_lt_ctl03_pageplaceholder_p_lt_ctl01_ContactForm_viewBiz_LastName_txtText"));

                lastName.SendKeys("Cordy");

                IWebElement submit =
                    driver.FindElement(By.Id("p_lt_ctl03_pageplaceholder_p_lt_ctl01_ContactForm_viewBiz_btnOK"));



                Assert.AreEqual("Planit - Contact Planit: The Leaders in Quality Engineering", driver.Title, "Strings do not match");


            
            }
        }
    }
}
  
