using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SpecFlowFrameworkDemo.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowFrameworkDemo.Factories
{
    class WaitClassUtil : PageObjects
    {
        private static IWebDriver _driver;
        public WaitClassUtil(IWebDriver webDriver) : base(webDriver)
        {
            _driver = webDriver;
        }

        WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));

        public void WaitUntilElementExistWithID(string ElementID)
        {
            IWebElement SearchResult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id(ElementID)));
        }

        public void WaitUntilElementExistWithXpath(string xpath)
        {
            IWebElement SearchResult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(xpath)));
        }

        public void WaitUntilElementToBeClickableWithID(string ElementID)
        {
            IWebElement SearchResult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(ElementID)));
        }

        public void WaitUntilElementToBeClickableWithXpath(string xpath)
        {
            IWebElement SearchResult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpath)));
        }
    }
}
