using AutoItX3Lib;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SpecFlowFrameworkDemo.Pages
{
    class Grants : PageObjects
    {

        private static IWebDriver _driver;
        WebDriverWait wait;
        public Grants(IWebDriver webDriver) : base(webDriver)
        {
            _driver = webDriver;

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }


        IWebElement PartnersMenuLink => _driver.FindElement(By.CssSelector("#top-menu>li:nth-child(5)>a"));
        IWebElement PartnerNewButton => _driver.FindElement(By.XPath("//*[@id='organisation_grid']//*[text()='New']"));
        IWebElement PartnerName => _driver.FindElement(By.Id("Organisation_Name"));
        IWebElement PartnerCode => _driver.FindElement(By.Id("Organisation_Code"));
        IWebElement PartnerEmail => _driver.FindElement(By.Id("Organisation_EmailAddress"));
        IWebElement PartnerPhone => _driver.FindElement(By.Id("Organisation_PhoneNumber"));
        IWebElement PartnerAddressLine1 => _driver.FindElement(By.Id("Organisation_AddressLine1"));
        IWebElement PartnerAddressLine2 => _driver.FindElement(By.Id("Organisation_AddressLine2"));
        IWebElement PartnerAddressLine3 => _driver.FindElement(By.Id("Organisation_AddressLine3"));
        IWebElement PartnerCountryAArrow => _driver.FindElement(By.XPath(".//*[@aria-controls='Organisation_CountryId_listbox']//*[@class='k-icon k-i-arrow-60-down']"));
        IWebElement PartnerCountrySelect => _driver.FindElement(By.XPath(".//*[@id='Organisation_CountryId_listbox']/li[2]"));
        IWebElement PartnerTypeArrow => _driver.FindElement(By.XPath(".//*[@aria-controls='Organisation_PartnerType_listbox']//*[@class='k-icon k-i-arrow-60-down']"));
        IWebElement PartnerTypeSelect => _driver.FindElement(By.XPath(".//*[@id='Organisation_PartnerType_listbox']/li[2]"));
        IWebElement PartnerNotes => _driver.FindElement(By.Id("Organisation_Notes"));
        IWebElement PartnerSubmit => _driver.FindElement(By.XPath(".//input[@type='submit']"));
        IWebElement UpdatedDate => _driver.FindElement(By.XPath(".//*[@data-title='Updated Date']"));
        IWebElement NameFilter => _driver.FindElement(By.XPath(".//*[@title='Name']/a[@title='Filter']"));

        IWebElement NameFilterText => _driver.FindElement(By.XPath(".//*[@class='k-textbox']"));
        IWebElement NameFilterButton => _driver.FindElement(By.XPath(".//button[@title='Filter']"));
        IWebElement PartnerEditIcon => _driver.FindElement(By.XPath("(.//*[@class='k-icon k-i-edit'])[1]"));
        IWebElement GrantTab => _driver.FindElement(By.Id("organisationEditTabStrip-tab-2"));
        IWebElement GrantNew => _driver.FindElement(By.XPath(".//*[@id='grant_grid']//*[text()='New']"));

        IWebElement GrantAmount => _driver.FindElement(By.XPath(".//*[@id='GrantCreateWindow']//*[@id='Amount']/preceding-sibling::input"));
        IWebElement GrantAmountValue => _driver.FindElement(By.XPath(".//*[@id='Amount']"));
        IWebElement GrantDate => _driver.FindElement(By.Id("Date"));
        IWebElement GrantNotes => _driver.FindElement(By.XPath(".//*[@id='GrantCreateWindow']//textarea[@id='Notes']"));
        IWebElement GrantSubmit => _driver.FindElement(By.XPath(".//*[@id='GrantCreateWindow']//*[@type='submit']"));
        IWebElement GrantEditIcon => _driver.FindElement(By.XPath(".//*[@id='grant_grid']//*[@class='k-icon k-i-edit']"));
        IWebElement GrantApprove => _driver.FindElement(By.XPath(".//*[@title='Approve']"));
        IWebElement GrantSave => _driver.FindElement(By.Id("btn__grantSubmit"));
        IWebElement AllocationTab => _driver.FindElement(By.Id("grantEditTabStrip-tab-2"));
        IWebElement AllocationNew => _driver.FindElement(By.XPath(".//*[@id='allocation_grid']//*[text()='New']"));
        IWebElement AllocationProgrammeArrow => _driver.FindElement(By.XPath(".//*[@aria-controls='ProgrammeId_listbox']//*[@class='k-icon k-i-arrow-60-down']"));
        IWebElement AllocationProgrammeSelect => _driver.FindElement(By.XPath(".//*[@id='ProgrammeId_listbox']/li[1]"));

        IWebElement AllocationAmount => _driver.FindElement(By.XPath(".//*[@id='InitialAllocation']/preceding-sibling::input"));
        IWebElement AllocationAmountValue => _driver.FindElement(By.XPath(".//*[@id='InitialAllocation']"));
        IWebElement AllocationNotes => _driver.FindElement(By.XPath(".//*[@id='AllocationCreateWindow']//*[@id='AllocationNotes']"));
        IWebElement AllocationSubmit => _driver.FindElement(By.XPath(".//*[@id='AllocationCreateWindow']//*[@type='submit']"));
        IWebElement AllocationEditLink => _driver.FindElement(By.XPath(".//*[@id='allocation_grid']//*[@class='iconLink']"));

        IWebElement AllocationApprove => _driver.FindElement(By.Id("btn__approveAllocation"));
        IWebElement AllocationSave => _driver.FindElement(By.Id("btn__allocationSubmit"));

        IWebElement AdjustmentTab => _driver.FindElement(By.Id("allocationEditTabStrip-tab-2"));
        IWebElement AdjustmentNew => _driver.FindElement(By.XPath(".//*[@id='adjustment_grid']//*[text()='New']"));
        IWebElement AdjustmentToArrow => _driver.FindElement(By.XPath(".//*[@aria-controls='ToProgrammeId_listbox']//*[@class='k-icon k-i-arrow-60-down']"));
        IWebElement AdjustmentToSelect => _driver.FindElement(By.XPath(".//*[@id='ToProgrammeId_listbox']/li[1]"));

        IWebElement AdjustmentAmount => _driver.FindElement(By.XPath(".//*[@id='AdjustmentCreateWindow']//*[@id='AdjustmentAmount']/preceding-sibling::input"));
        IWebElement AdjustmentAmountValue => _driver.FindElement(By.XPath(".//*[@id='AdjustmentAmount']"));
        IWebElement AdjustmentNotes => _driver.FindElement(By.XPath(".//*[@id='AdjustmentCreateWindow']//*[@id='AdjustmentNotes']"));
        IWebElement AdjustmentSubmit => _driver.FindElement(By.XPath(".//*[@id='AdjustmentCreateWindow']//*[@type='submit']"));
        IWebElement AdjustmentEditLink => _driver.FindElement(By.XPath("//a[@class='iconLink']"));

        IWebElement AdjustmentApprove => _driver.FindElement(By.Id("btn__approveAdjustment"));

        IWebElement AdjustmentSave => _driver.FindElement(By.Id("btn__adjustmentSubmit"));

        public void CreatePartner(string PName, string PNumber)
        {
            wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(".//*[@class='navbar-collapse topbar-nav']//a[text()='Programmes']")));

            Thread.Sleep(1000);
            PartnersMenuLink.Click();
            PartnerNewButton.Click();
            PartnerName.SendKeys(PName);
            PartnerCode.SendKeys(PNumber);
            PartnerEmail.SendKeys("chandana-kotagiri@intouch-business.com");
            PartnerPhone.SendKeys("07766778899");
            PartnerAddressLine1.SendKeys("Peregrine House");
            PartnerAddressLine2.SendKeys("Ford,Arundel");
            PartnerAddressLine3.SendKeys("West Sussex");
            PartnerCountryAArrow.Click();
            PartnerCountrySelect.Click();
            PartnerTypeArrow.Click();
            PartnerTypeSelect.Click();
            PartnerNotes.SendKeys("Created by automation script");
            PartnerSubmit.Click();
            Thread.Sleep(3000);
            NameFilter.Click();
            Thread.Sleep(500);
            NameFilterText.SendKeys(PName);
            NameFilterButton.Click();
            Thread.Sleep(2000);
            PartnerEditIcon.Click();
        }



        public void CreateGrant()
        {

            GrantTab.Click();
            Thread.Sleep(1000);
            GrantNew.Click();
            Thread.Sleep(1000);
            GrantAmount.Click();
            GrantAmountValue.Clear();
            GrantAmount.Click();
            GrantAmountValue.SendKeys("9000000");
            GrantNotes.SendKeys("Test notes entered by automation");
            GrantSubmit.Click();
            Thread.Sleep(1000);
            GrantEditIcon.Click();
            GrantApprove.Click();
            GrantSave.Click();

        }

        public void CreateAllocation()
        {
            Thread.Sleep(1000);
            AllocationTab.Click();
            Thread.Sleep(1000);
            AllocationNew.Click();

            Thread.Sleep(1000);
            AllocationProgrammeArrow.Click();
            AllocationProgrammeSelect.Click();
            AllocationAmount.Click();
            AllocationAmountValue.Clear();
            AllocationAmount.Click();
            AllocationAmountValue.SendKeys("100");
            AllocationNotes.SendKeys("Test notes enetered by automation");
            AllocationSubmit.Click();
            Thread.Sleep(500);
            AllocationEditLink.Click();
            AllocationApprove.Click();
            AllocationSave.Click();
            
           


        }
        public void CreateAdjustment()

        {

            Thread.Sleep(1000);
            AdjustmentTab.Click();
            Thread.Sleep(1000);
            AdjustmentNew.Click();
            Thread.Sleep(1000);
            AdjustmentToArrow.Click();
            AdjustmentToSelect.Click();
            AdjustmentAmount.Click();
            AdjustmentAmountValue.Clear();
            AdjustmentAmount.Click();
            AdjustmentAmountValue.SendKeys("10");

            AdjustmentNotes.SendKeys("Automated script entered notes");
            AdjustmentSubmit.Click();
            AdjustmentEditLink.Click();
            Thread.Sleep(1000);

            AdjustmentApprove.Click();
            AdjustmentSave.Click();

        }




    }
        


}