using System;
using System.Collections.Generic;
using System.Text;
using NUnit;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestTask
{
    class GoogleSmth_Test
    {
        private string _browserName;
        private IWebDriver _driver;
        private GooglePage googlePage;

        private string desiredInfo = "Selenium IDE export to C#";

        public GoogleSmth_Test()
        {
            googlePage = new GooglePage();
        }


        [SetUp]
        public void Initialize()
        {
            _driver = new ChromeDriver();
        }

        [Test]
        [TestCase]
        public void CheckGoogleSearchResultsContainText()
        {
            var result = googlePage.GoogleFor(desiredInfo);
            Assert.True(result.Contains("Selenium IDE"));
        }

        [TearDown]
        public void EndTest()
        {
            _driver.Close();
        }
    }
}
