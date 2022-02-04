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
    class CreateWorkItem : PageObjects
    {

        private static IWebDriver _driver;
        public CreateWorkItem(IWebDriver webDriver) : base(webDriver)
        {
            _driver = webDriver;

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        IWebElement NewButton => _driver.FindElement(By.XPath("//*[text()= 'New']"));
        IWebElement WIName => _driver.FindElement(By.XPath(".//input[@id= 'Name']"));
        IWebElement ProjectDropDown => _driver.FindElement(By.CssSelector("div[data-container-for='ContainerTypeSelector'] .k-select"));
        IWebElement SelectProject => _driver.FindElement(By.CssSelector("#ContainerTypeSelector-list li[data-offset-index='0']"));

        IWebElement Container => _driver.FindElement(By.CssSelector("div[data-container-for='Container'] .k-select"));
        IWebElement SelectContainer => _driver.FindElement(By.CssSelector("#Container_listbox li[data-offset-index='7']"));

        IWebElement Stage => _driver.FindElement(By.XPath(".//*[@data-container-for= 'StageId']//*[@class = 'k-select']"));
        IWebElement SelectStage => _driver.FindElement(By.CssSelector("#StageId_listbox li[data-offset-index='0']"));

        IWebElement Type => _driver.FindElement(By.CssSelector("div[data-container-for='TypeId'] .k-select"));
        IWebElement SelectType => _driver.FindElement(By.CssSelector("#TypeId_listbox li[data-offset-index='0']"));

        IWebElement SaveButton => _driver.FindElement(By.XPath(".//button[text() ='Save']"));
        IWebElement SuccessPopUp => _driver.FindElement(By.XPath(".//*[text() ='Work Item Created Successfully.']"));

        IWebElement NameFilter => _driver.FindElement(By.XPath(".//*[@title='Name']//span[@class='k-icon k-i-filter']"));

        IWebElement FilterText => _driver.FindElement(By.XPath("//input[@class='k-textbox' and @title='Value']"));

        IWebElement FilterButton => _driver.FindElement(By.XPath("//button[@type='submit']"));

        IWebElement EditIconLink => _driver.FindElement(By.XPath("//*[@class='iconLink']"));

        IWebElement WIStatus => _driver.FindElement(By.XPath("//span[@aria-labelledby='WorkItem_StatusId_label']//span[@class='k-select']"));

        IWebElement WIStatusSelect => _driver.FindElement(By.CssSelector("[id='WorkItem_StatusId_listbox'] li[data-offset-index ='1']"));

        IWebElement WIOwner => _driver.FindElement(By.XPath("//span[@aria-labelledby='WorkItem_OwnerId_label']//span[@class='k-select']"));

        IWebElement WIOwnerSelect => _driver.FindElement(By.CssSelector("[id='WorkItem_OwnerId_listbox'] li[data-offset-index = '2']"));

        IWebElement WIPriority => _driver.FindElement(By.XPath(".//*[ @aria-owns='WorkItem_PriorityId_listbox']//span[@class='k-select']"));
        IWebElement WIPrioritySelect => _driver.FindElement(By.XPath(".//*[@id='WorkItem_PriorityId_listbox']//li[@data-offset-index= '1']"));

        IWebElement WIDescription => _driver.FindElement(By.XPath("/html/body"));

        IWebElement WIInternalUser => _driver.FindElement(By.CssSelector("[aria-controls ~='SelectedInternalUsers_listbox']"));
       

       IWebElement WIInternalUserSelect => _driver.FindElement(By.XPath(".//ul[@id = 'SelectedInternalUsers_listbox']/li[1]"));

        IWebElement WIExternalUser => _driver.FindElement(By.CssSelector("[aria-controls ~='SelectedExternalUsers_listbox']"));
        IWebElement WIExternalUserSelect => _driver.FindElement(By.CssSelector("#SelectedExternalUsers_listbox li[data-offset-index='0']"));

        IWebElement WITargetStartDate => _driver.FindElement(By.XPath(".//input[@id='WorkItem_TargetStartDate']"));
        IWebElement WITargetEndDate => _driver.FindElement(By.XPath(".//input[@id='WorkItem_TargetEndDate']"));

        IWebElement WIActualStartDate => _driver.FindElement(By.XPath(".//input[@id='WorkItem_ActualStartDate']"));
        IWebElement WIActualEndDate => _driver.FindElement(By.XPath(".//input[@id='WorkItem_ActualEndDate']"));

        //IWebElement Frame => _driver.FindElement(By.XPath("(.//iframe[@class='k-content'])[1]"));
         IWebElement PlusIcon =>  _driver.FindElement(By.XPath(".//*[@class='fa fa-plus']"));

         IWebElement AddApprover => _driver.FindElement(By.XPath("(.//*[@id='wn_approval-form_wnd_title'])[1]"));

        IWebElement ApproverIsRequired => _driver.FindElement(By.Id("IsRequired"));
        IWebElement ApproverSubmitButton => _driver.FindElement(By.XPath(".//button[@class='btn btn-primary']"));


        IWebElement WISave => _driver.FindElement(By.XPath(".//*[@id='btn__workItemSubmit']"));

        IWebElement DiscussionTab => _driver.FindElement(By.Id("workItemEditTabStrip-tab-2"));
        IWebElement AddNewCommentButton => _driver.FindElement(By.Id("addNewComment"));
        IWebElement ConditionTab => _driver.FindElement(By.Id("workItemEditTabStrip-tab-3"));
        IWebElement AddButton => _driver.FindElement(By.XPath(".//*[@id='add-condition']"));
        IWebElement IssueTab => _driver.FindElement(By.Id("workItemEditTabStrip-tab-4"));
        IWebElement IssuesNewButton => _driver.FindElement(By.XPath("(.//a[text() = 'New'])[1]"));
        IWebElement CreateIssueName => _driver.FindElement(By.XPath(".//input[@id = 'Name']"));
        IWebElement CreateIssueSubmitButton => _driver.FindElement(By.XPath(".//button[@type='submit']"));

        IWebElement DocumentsTab => _driver.FindElement(By.Id("workItemEditTabStrip-tab-5"));
        IWebElement DocNewButton => _driver.FindElement(By.XPath(".//*[@id='work_item_documents_grid']//*[text()='New']"));

        IWebElement DocTypeArrow => _driver.FindElement(By.XPath(".//*[@id='DocumentTypeId_label']/following-sibling::span//span[@class='k-icon k-i-arrow-60-down']"));
        IWebElement DocTypeSelection => _driver.FindElement(By.XPath(".//ul[@id='DocumentTypeId_listbox']/li[2]"));
        IWebElement DocSubtypeArrow => _driver.FindElement(By.XPath(".//*[@id='DocumentSubtypeId_label']/following-sibling::span//span[@class='k-icon k-i-arrow-60-down']"));

        IWebElement DocSubTypeSelection => _driver.FindElement(By.XPath(".//ul[@id='DocumentSubtypeId_listbox']/li[2]"));
        IWebElement DocSelectFiles => _driver.FindElement(By.XPath(".//*[text()='Files']/following-sibling::div//div[@aria-label='Select files...']"));
        IWebElement DocExportToExcel => _driver.FindElement(By.XPath(".//span[@class='k-icon k-i-file-excel']"));
        IWebElement DocDocumentTemplates => _driver.FindElement(By.XPath(".//*[@class='k-button k-button-icontext k-grid-btn-document-templates']"));
        IWebElement UploadSaveButton => _driver.FindElement(By.XPath(".//*[text() ='Files']/parent::div/following-sibling::div//*[@class='btn btn-primary']"));



        public void ClickNewButton()
        {

            NewButton.Click();
          
        }


        public void EnterDataInName(string pname)
        {
            
            WIName.SendKeys(pname);

        }


        public void SelectProjectProgramme()
        {

            ProjectDropDown.Click();
            SelectProject.Click();

        }
        public void ContainerDropDown()
        {
            Thread.Sleep(1000);
            Container.Click();
            Thread.Sleep(1000);
            SelectContainer.Click();

        }
        public void ClickStageDropDown()
        {
            Thread.Sleep(1000);
           Stage.Click();
            Thread.Sleep(1000);
            SelectStage.Click();
        }
        public void ClickTypeDropDown()
        {
            Thread.Sleep(1000);
            Type.Click();
            Thread.Sleep(1000);
            SelectType.Click();
        }

        public void ClickSaveButton()
        {

            SaveButton.Click();

        }


        public string VerifySuccessPopUp()
        {
            
            return SuccessPopUp.Text;
         
        }


        public void NameFilterClick()
        {
            Thread.Sleep(1000);
            NameFilter.Click();
        
        }

        public void EnterFilterText(string pname)
        {
            Thread.Sleep(1000);
            FilterText.SendKeys(pname);

        }

        public void ClickFilterButton()

        {
            FilterButton.Click();

        }

        public void ClickEditIconLink()
        {
            Thread.Sleep(1000);
            EditIconLink.Click();
        }


        public void WIStatusDropDown()
        {

            WIStatus.Click();
            WIStatusSelect.Click();
        }

        public void WIOwnerDropDown()
        {

            WIOwner.Click();
            Thread.Sleep(1000);
            WIOwnerSelect.Click();
            Thread.Sleep(1000);
        }


        public void WIPriorityDropDown()
        {

            WIPriority.Click();
            WIPrioritySelect.Click();
            Thread.Sleep(1000);
        }


        public void EnterDates(string WITSDate, string WITEDate, string WIASDate,string WIAEDate)
        {
            WITargetStartDate.SendKeys(WITSDate);
            WITargetEndDate.SendKeys(WITEDate);
            WIActualStartDate.SendKeys(WIASDate);
            WIActualEndDate.SendKeys(WIAEDate);
        
        }

        
        public void EnterWIDescription()
         {
            _driver.SwitchTo().Frame(_driver.FindElement(By.XPath("(.//iframe[@class='k-content'])[1]")));
            WIDescription.Click();
            WIDescription.SendKeys("Automated description entered");
            _driver.SwitchTo().DefaultContent();
        }


       


        public string ClickPlustoEnterApprover()
        {
            //WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            Thread.Sleep(3000);
            IWebElement PlusIcon = _driver.FindElement(By.XPath(".//*[@class='fa fa-plus']"));
            if (PlusIcon.Displayed)
            {

                _driver.FindElement(By.XPath(".//*[@class='fa fa-plus']")).Click();
               
            }
            Thread.Sleep(3000);
            ApproverIsRequired.Click();
            
            return AddApprover.Text;
            

        }


        public void ClickApproverSubmit()
        {
            ApproverSubmitButton.Click();

        }
        public void SelectInternalUser()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            Actions action = new Actions(_driver);
            for (int i= 1; i<4; i++)
            { 
           
            WIInternalUser.Click();

            IWebElement WIInternalUserVisible = _driver.FindElement(By.XPath(".//ul[@id='SelectedInternalUsers_listbox']"));
                string userselected = WIInternalUserVisible.Text;

                if (WIInternalUserVisible.Displayed)
                {
                   
                    action.MoveToElement(_driver.FindElement(By.XPath(".//ul[@id = 'SelectedInternalUsers_listbox']/li["+i+"]"))).Build();
                    action.Click().Perform();
                   
                }   
            }
            action.SendKeys(Keys.Tab);
         
        }


        public void SelectExternalUser()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            Actions action = new Actions(_driver);
            for (int i = 1; i < 4; i++)
            {

                WIExternalUser.Click();

                IWebElement WIExternalUserVisible = _driver.FindElement(By.XPath("(.//ul[@id='SelectedExternalUsers_listbox'])[2]"));
                if (WIExternalUserVisible.Displayed)
                {

                    action.MoveToElement(_driver.FindElement(By.XPath("(.//ul[@id ='SelectedExternalUsers_listbox'])[2]/li["+i+"]"))).Build();
                    action.Click().Perform();

                }
            }
            action.SendKeys(Keys.Tab);
        }


        public void ClickWISaveButton()
        {
            
            WISave.Click();
        }




        public void ClickDiscussionTab()
        {

            DiscussionTab.Click();
        }

        public void AddComment()
        {
            _driver.SwitchTo().Frame(_driver.FindElement(By.XPath("(.//iframe[@class='k-content'])[2]")));
            WIDescription.Click();
            WIDescription.SendKeys("Test Comment entered by automation");
            _driver.SwitchTo().DefaultContent();
            AddNewCommentButton.Click();

        }

        //In feature call the save method

        public void ConditionsTab()
        {
            ConditionTab.Click();
            AddButton.Click();
           
            _driver.FindElement(By.XPath(".//*[contains(@id,'_Text')]")).SendKeys("Automation script condition1");

        }
        //Click the save button by calling in the feature file


        public void IssuesTab()
        {
            IssueTab.Click();
            Thread.Sleep(3000);
            IssuesNewButton.Click();
            Thread.Sleep(1000);
            CreateIssueName.Click();
            Thread.Sleep(1000);
            CreateIssueName.SendKeys("Test Issue created by automation script");
            Thread.Sleep(1000);
            CreateIssueSubmitButton.Click();
            Thread.Sleep(1000);

        }
        //Click the save button by calling in the feature file



        public void DocumentSelection()
        {
            Thread.Sleep(1000);
            DocumentsTab.Click();
            Thread.Sleep(1000);
            DocNewButton.Click();
            Thread.Sleep(1000);
            DocTypeArrow.Click();
           DocTypeSelection.Click();
           DocSubtypeArrow.Click();
           DocSubTypeSelection.Click();

            string filenamenew = System.IO.Directory.GetParent(@"../../../").FullName;
            string fileName = filenamenew + "\\Resources\\SSMyClaims.xls";
            DocSelectFiles.Click();
            AutoItX3 autoit = new AutoItX3();
            autoit.WinActivate("Open");
            Thread.Sleep(5000);
            autoit.Send(fileName);
            Thread.Sleep(3000);
            autoit.Send("{ENTER}");
            Thread.Sleep(1000);
            UploadSaveButton.Click();
        }


    }
}