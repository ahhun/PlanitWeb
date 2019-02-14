using System;
using TechTalk.SpecFlow;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PlanitWebTest
{
    [Binding]
    public class AbilityToMakeGeneralEnquirySteps
    {
        private IWebDriver _driver;

        [Given(@"I can access the Planit homepage")]
        public void GivenICanAccessThePlanitHomepage()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://www.planittesting.com/Contact");
        }

        [Given(@"I can select the (.*) button")]
        public void GivenICanSelectTheButton(string p0)
        {
            IWebElement firstname = _driver.FindElement(By.Id("p_lt_ctl03_pageplaceholder_p_lt_ctl01_ContactForm_viewBiz_FirstName_txtText"));
        }

        [Given(@"I can entered (.*) in firstname")]
        public void GivenICanEnteredJeffInFirstname(string firstname)
        {
            IWebElement firstname1 = _driver.FindElement(By.Id("p_lt_ctl03_pageplaceholder_p_lt_ctl01_ContactForm_viewBiz_FirstName_txtText"));
            firstname1.SendKeys(firstname);
        }

        [Given(@"I can enter (.*) in lastname")]
        public void GivenICanEnterGorgInLastname(string lastname)
        {
            IWebElement lastName = _driver.FindElement(By.Id("p_lt_ctl03_pageplaceholder_p_lt_ctl01_ContactForm_viewBiz_LastName_txtText"));
            lastName.SendKeys(lastname);
        }

        [When(@"I submit my enquiry")]
        public void WhenISubmitMyEnquiry()
        {
            IWebElement submit = _driver.FindElement(By.Id("p_lt_ctl03_pageplaceholder_p_lt_ctl01_ContactForm_viewBiz_btnOK"));
            submit.Click();
        }

        [Then(@"I should see an error message to fill in job title")]
        public void ThenIShouldSeeAnErrorMessageToFillInJobTitle()
        {

        }
        [AfterScenario]
        public void DisposeWebDriver()
        {
            _driver.Dispose();
        }
    }

}
