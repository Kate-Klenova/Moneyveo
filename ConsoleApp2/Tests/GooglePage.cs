using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Internal;

namespace TestTask
{
    class GooglePage
    {
        private readonly IWebDriver _driver;
        public List<IWebElement> content_data = new List<IWebElement>();

        public static By SearchInput = By.XPath("//input[@name = 'q']");


        public GooglePage()
        {
            _driver = new ChromeDriver();
        }

  

            public string GoogleFor(string userInput)
        {
            _driver.Navigate().GoToUrl("www.google.com");
            _driver.FindElement(SearchInput).SendKeys(userInput);
            content_data = _driver.FindElement(By.XPath("//div(class = 'srg'")).FindElements(By.TagName("div")).ToList();
            return content_data[3].ToString();
        }
    }
}
