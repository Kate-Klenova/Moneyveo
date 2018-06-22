using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Internal;

namespace Tests.Tests
{
    class GooglePage
    {
        private readonly IWebDriver _driver;
        public static By SearchInput = By.XPath("//input[@name = 'q']");
        public static By SearchButton = By.XPath("//input[@name = 'btnK']");
        public static By AllResultLinksOnPage1 = By.XPath("//div[@class = 'srg']//h3/a");

        public GooglePage(IWebDriver webDriver)
        {
            _driver = webDriver;
        }
        public void GoogleForInfo(string userInput)
        {
            _driver.Navigate().GoToUrl("https://www.google.com/");
            _driver.FindElement(SearchInput).SendKeys(userInput + Keys.Tab);
            _driver.FindElement(SearchButton).Click();            
        }
        public string FindRequiredtLink(int requiredLinkNo)
        {
            var allLinks = _driver.FindElements(AllResultLinksOnPage1);
            return allLinks[requiredLinkNo].Text; 
        }
    }
}
