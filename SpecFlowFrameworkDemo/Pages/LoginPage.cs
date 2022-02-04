using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SpecFlowFrameworkDemo.Factories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace SpecFlowFrameworkDemo.Pages
{

    class LoginPage : PageObjects
    {
        WebDriverWait wait;

        private static  IWebDriver _driver;
        public LoginPage(IWebDriver webDriver) : base(webDriver)
        {
            _driver = webDriver;

           _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        }
      // WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        //WaitClassUtil wait = new WaitClassUtil(_driver);




        public IWebElement LoginId => _driver.FindElement(By.Id("i0116"));
       // public IWebElement SignInButton => _driver.FindElement(By.Id("idSIButton9"));
        public IWebElement Password => _driver.FindElement(By.Id("i0118"));
        public IWebElement NextButton => _driver.FindElement(By.Id("idSIButton9"));

        public IWebElement QuickLinks => _driver.FindElement(By.XPath(".//*[@class='fa fa-fw fa-bookmark fa-lg rPadIcon']"));

        public IWebElement WorkItems => _driver.FindElement(By.XPath(".//*[text()= 'Work Items']"));

        public IWebElement Dashboard => _driver.FindElement(By.XPath(".//*[text()='Dashboard']"));

              public void Login(String UserName, string password)
        {
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("i0116")));
            LoginId.SendKeys(UserName);
            Thread.Sleep(3000);
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("idSIButton9")));
            // wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("i0116")));
            // wait.WaitUntilElementExistWithID(NextButton.ToString());
            NextButton.Click();
            Thread.Sleep(3000);
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("i0118")));
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(password.ToString())));
            // wait.WaitUntilElementExistWithID(password.ToString());
            Password.SendKeys(password);
        }

        public void ClickStaySignIn()
        {
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("idSIButton9")));
            _driver.FindElement(By.Id("idSIButton9")).Click();
        }


        public void ClickLoginButton()
        {
            // wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("idSIButton9")));
            _driver.FindElement(By.Id("idSIButton9")).Click();
            
        }

        public string VerifyPageTitle()
        {
            return _driver.FindElement(By.XPath(".//*[text()='Dashboard']")).Text;
            
        
        }



        public void NavigateToWorkItems()
        {
            QuickLinks.Click();
            WorkItems.Click();

        }







    }
}
