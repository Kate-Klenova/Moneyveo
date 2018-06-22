using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tests.Tests
{
   [TestFixture]
   public class GoogleTest
    {
        private IWebDriver _driver;
        private string desiredInfo = "Selenium IDE export to C#";
        private string expectedInfo = "Selenium IDE";

        [SetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
        }

        [Test]
        public void CheckGoogleSearchResultsContainText()
        {
            var googlePage = new GooglePage(_driver);
            googlePage.GoogleForInfo(desiredInfo);
            Assert.True(googlePage.FindRequiredtLink(3).Contains(expectedInfo));
        }

        [TearDown]
        public void EndTest()
        {
            _driver.Quit();
        }
    }
}
