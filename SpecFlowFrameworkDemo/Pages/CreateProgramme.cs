using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System;
using System.Collections.Generic;
using System.Text;
using SpecFlowFrameworkDemo.Resources;

namespace SpecFlowFrameworkDemo.Pages
{
         class CreateProgramme : PageObjects
        {
           
            private static IWebDriver _driver;
            WebDriverWait wait;

            public CreateProgramme(IWebDriver webDriver) : base(webDriver)
            {
             _driver = webDriver;
             wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

             _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
          
            }
        IWebElement ProgrammeMenuLink => _driver.FindElement(By.XPath(".//*[@class='navbar-collapse topbar-nav']//a[text()='Programmes']"));
        IWebElement ProgrammeNameFilter => _driver.FindElement(By.XPath(".//*[text()= 'Name']/preceding-sibling::a/span"));
        IWebElement ProgrammeNameFilterText => _driver.FindElement(By.XPath(".//*[@title= 'Value']"));
        IWebElement ProgrammeNameFilterButton => _driver.FindElement(By.XPath(".//*[@type= 'submit']"));
        IWebElement ProgrammeEditIcon => _driver.FindElement(By.XPath(".//*[@class= 'k-icon k-i-edit']"));
        IWebElement ProgrammeNewButton => _driver.FindElement(By.CssSelector(".k-button.k-button-icontext.k-grid-intouchGridPopUpInsert"));
        IWebElement ProgrammeName => _driver.FindElement(By.CssSelector("#Name"));
        IWebElement ProgrammeCode => _driver.FindElement(By.CssSelector("#Code"));
        IWebElement ProgrammeStartDate => _driver.FindElement(By.CssSelector("#StartDate"));
        IWebElement ProgrammeEndDate => _driver.FindElement(By.CssSelector("#EndDate"));
        IWebElement PrgDonorCurrency => _driver.FindElement(By.XPath(".//div[@data-container-for ='DonorCurrencyId']//span[@class='k-select']"));
        IWebElement PrgDonorCurrencySelect => _driver.FindElement(By.XPath(".//ul[@id ='DonorCurrencyId_listbox']//li[@data-offset-index='2']"));
        IWebElement PrgProcessTemplate => _driver.FindElement(By.XPath(".//div[@data-container-for='ProcessTemplateId']//span[@class='k-select']"));
        IWebElement PrgProcessTemplateSelect => _driver.FindElement(By.XPath(".//ul[@id ='ProcessTemplateId_listbox']//li[@data-offset-index='1']"));
        IWebElement ProgrammeSaveButton => _driver.FindElement(By.XPath(".//button[@type= 'submit']"));
        IWebElement PrgSuccessPopUp => _driver.FindElement(By.XPath(".//*[text() ='Programme Created Successfully.']"));





        public void ClickPrgMenuButton()
        {
            wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(".//*[@class='navbar-collapse topbar-nav']//a[text()='Programmes']")));
            ProgrammeMenuLink.Click();
        }
        public void ClickNewButton()
          {
            ProgrammeNewButton.Click();
          }
        public void EnterProgrammeDetails(string PName, string PCode, string PSDate, string PEDate)
        {
            ProgrammeName.SendKeys(PName);
            ProgrammeCode.SendKeys(PCode);
            ProgrammeStartDate.SendKeys(PSDate);
            ProgrammeEndDate.SendKeys(PEDate);
            PrgDonorCurrency.Click();
            PrgDonorCurrencySelect.Click();
            PrgProcessTemplate.Click();
            PrgProcessTemplateSelect.Click();
           

        }
        public void ClickSaveButton()
        {
            ProgrammeSaveButton.Click();
        }
        public string VerifyPrgSuccessPopUp()
        {

            return PrgSuccessPopUp.Text;

        }


        public void ClickOnNameFilter(string programmename)
        {

            ProgrammeNameFilter.Click();
            ProgrammeNameFilterText.SendKeys(programmename);
            ProgrammeNameFilterButton.Click();


        }

        public void ClickOnProgrammeEditIcon()
        {
            Thread.Sleep(2000);
            ProgrammeEditIcon.Click();
           

        }

    }
}
