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
    class PrgEditKIPage : PageObjects
    {
        WebDriverWait wait;

        private static IWebDriver _driver;

        Actions action;
        public PrgEditKIPage(IWebDriver webDriver) : base(webDriver)
        {
            _driver = webDriver;

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));

            action = new Actions(_driver);
        }


        IWebElement KeyInformationTab => _driver.FindElement(By.Id("programmeEditTabStrip-tab-2"));
        IWebElement ExpectedCmtForInvestment => _driver.FindElement(By.XPath(".//*[@id='Programme_ExpectedCommitmentForInvestment']/preceding-sibling::input"));
        IWebElement ExpectedCmtForInvestmentValue => _driver.FindElement(By.XPath(".//*[@id='Programme_ExpectedCommitmentForInvestment']"));
        IWebElement ExpectedCoFinancing => _driver.FindElement(By.XPath(".//*[@id='Programme_ExpectedCofinancing']/preceding-sibling::input"));

        IWebElement ExpectedCoFinancingValue => _driver.FindElement(By.XPath(".//*[@id='Programme_ExpectedCofinancing']"));
        IWebElement ProgrammeSaveButton => _driver.FindElement(By.Id("btn__programmeSubmit"));


        IWebElement ProcessTrackerTab => _driver.FindElement(By.XPath(".//*[@id='processTrackerTab']"));
        IWebElement ProcessTrackerExportToExcel => _driver.FindElement(By.XPath(".//*[@data-role='button']"));
        IWebElement ProcessTrackerNewButton => _driver.FindElement(By.XPath(".//*[@id='stageGrid']//*[text()='New']"));
        IWebElement ProcessTrackerCreateStageName => _driver.FindElement(By.XPath(".//*[@id='createWizard']//*[@id='Name']"));
        IWebElement ProcessTrackerCreateStageSaveButton => _driver.FindElement(By.XPath(".//*[@id='createWizard']//*[@class='k-button k-primary']"));

        IWebElement ProcessTrackerStageEditIcon(string name) => _driver.FindElement(By.XPath($".//td[text()='{name}']/preceding-sibling::td/a[@class='iconLink']"));

        IWebElement StageProgrammeLink => _driver.FindElement(By.XPath(".//*[text()='Programme']/following-sibling::a"));

        IWebElement StageOwnerArrow => _driver.FindElement(By.XPath("(.//*[@class='k-icon k-i-arrow-60-down'])[1]"));

        IWebElement StageOwnerArrowSelection => _driver.FindElement(By.XPath(".//*[@id='Stage_OwnerId_listbox']/li[4]"));

        
        IWebElement StageWorkItemTab => _driver.FindElement(By.Id("stageEditTabStrip-tab-2"));

        IWebElement StageWorkItemNew => _driver.FindElement(By.XPath(".//*[@name='workItemGrid']//*[text()='New']"));

        IWebElement StageWorkItemCreateName => _driver.FindElement(By.XPath(".//*[@id='Name']"));

        IWebElement StageWorkItemTypeArrow => _driver.FindElement(By.XPath(".//*[@aria-controls='TypeId_listbox']"));

        IWebElement StageWorkItemTypeSelect => _driver.FindElement(By.XPath(".//*[@id='TypeId_listbox']/li[1]"));
        IWebElement StageWorkItemTypeTextBox => _driver.FindElement(By.XPath("//input[@name='TypeId_input']"));

        IWebElement StageWorkItemSaveButton => _driver.FindElement(By.XPath(".//*[@id='workItemCreate_wnd_title']/parent::div/following-sibling::div//button[@type='submit']"));

        IWebElement ProcessTrackerDiscussionTab => _driver.FindElement(By.XPath(".//*[@id='stageEditTabStrip-tab-3']"));

       

        IWebElement ProcessTrackerDiscussionAddNewCommentButton => _driver.FindElement(By.XPath(".//*[@id='addNewComment']"));

        IWebElement ProcessTrackerStageSaveButton => _driver.FindElement(By.XPath(".//*[@class='btn btn-primary']"));

        IWebElement ProcessTrackerStageDetailsTab => _driver.FindElement(By.XPath(".//*[@aria-controls='stageEditTabStrip-1']"));

        IWebElement RiskTab => _driver.FindElement(By.Id("programmeEditTabStrip-tab-4"));
        IWebElement RiskNewButton => _driver.FindElement(By.XPath(".//*[@name='processFlowRisksGrid']//*[text()='New']"));
        IWebElement RiskNameField => _driver.FindElement(By.XPath(".//*[@id='workItemCreateWizard-0']//*[@id='Name']"));
        IWebElement RiskStageArrow => _driver.FindElement(By.XPath(".//*[@aria-controls='StageId_listbox']//*[@class='k-icon k-i-arrow-60-down']"));
        IWebElement RiskStageSelection => _driver.FindElement(By.XPath(".//*[@id='StageId_listbox']/li[1]"));

        IWebElement RiskImpactSlider => _driver.FindElement(By.XPath(".//*[@id='Impact']/parent::div/div/*[@title='drag']"));
        IWebElement RiskLikelihoodSlider => _driver.FindElement(By.XPath(".//*[@id='Likelihood']/parent::div/div/*[@title='drag']"));

        IWebElement RiskSaveButton => _driver.FindElement(By.XPath(".//button[text()='Save']"));

        IWebElement RiskMatrixButton => _driver.FindElement(By.XPath(".//button[text()='Risk Matrix']"));
        IWebElement RiskMatrixCloseButton => _driver.FindElement(By.XPath("(.//span[@id='createRiskMatrixPopup_wnd_title'])[1]/following-sibling::div"));


        IWebElement KanbanTab => _driver.FindElement(By.Id("programmeEditTabStrip-tab-5"));
        IWebElement KanbanPlusIcon => _driver.FindElement(By.XPath(".//i[@class='fa fa-plus']"));
        IWebElement KanbanName => _driver.FindElement(By.XPath(".//*[@id='workItemCreateWizard-0']//*[@id='Name']"));

        IWebElement KanbanStageArrow => _driver.FindElement(By.XPath(".//span[@aria-controls='StageId_listbox']/span[@class='k-icon k-i-arrow-60-down']"));
        IWebElement KanbanStageSelect => _driver.FindElement(By.XPath(".//*[@id='StageId_listbox']/li[1]"));
        IWebElement KanbanTypeArrow => _driver.FindElement(By.XPath(".//*[@aria-controls='TypeId_listbox']/span[@class='k-icon k-i-arrow-60-down']"));
        IWebElement KanbanTypeSelect => _driver.FindElement(By.XPath(".//*[@id='TypeId_listbox']/li[1]"));
        IWebElement KanbanSaveButton => _driver.FindElement(By.XPath(".//button[@class='k-button k-primary']"));

        IWebElement KanbanNotStarted => _driver.FindElement(By.XPath("(.//*[@data-status-id='1']//*[@class='workItem'])[1]"));
        IWebElement KanbanInProgress => _driver.FindElement(By.XPath(".//*[@id='Status2StageDummy']"));
        IWebElement KanbanWaiting => _driver.FindElement(By.XPath(".//*[@id='Status3StageDummy']"));
        IWebElement KanbanCompleted => _driver.FindElement(By.XPath(".//*[@id='Status4StageDummy']"));

        IWebElement KanbanWaitingFirstRecord => _driver.FindElement(By.XPath(".//*[@data-status-id='3']//*[@class='workItem__header']"));


        IWebElement ProjectsTab => _driver.FindElement(By.Id("programmeEditTabStrip-tab-6"));
        IWebElement ProjectNewButton => _driver.FindElement(By.XPath(".//*[@name='project_grid']//*[text()='New']"));
        IWebElement ProjectCreateNewName => _driver.FindElement(By.XPath(".//*[@ID='projectCreateWizard-0']//*[@id='Name']"));
        IWebElement ProjectProcessTemplateArrow => _driver.FindElement(By.XPath(".//*[@aria-controls='ProcessTemplateId_listbox']/span"));
        IWebElement ProjectProcessTemplateSelect => _driver.FindElement(By.XPath(".//*[@id='ProcessTemplateId_listbox']/li[6]"));

        IWebElement ProjectCreateNewSaveButton => _driver.FindElement(By.XPath(".//*[@aria-labelledby='projectCreateWindow_wnd_title']//*[@class='k-wizard-buttons-right']"));


        IWebElement InterventionsTab => _driver.FindElement(By.Id("programmeEditTabStrip-tab-7"));


        IWebElement InterventionNewButton => _driver.FindElement(By.XPath(".//*[@id='programme_intervention_grid']//*[text()='New']"));

        IWebElement InterventionTypeArrow => _driver.FindElement(By.XPath(".//*[@aria-owns='InterventionTypeId_listbox']//*[@class='k-icon k-i-arrow-60-down']"));

        IWebElement InterventionTypeSelection => _driver.FindElement(By.XPath(".//*[@id='InterventionTypeId_listbox']/li[2]"));

        IWebElement InterventionsArrow => _driver.FindElement(By.XPath(".//*[@aria-controls='InterventionId_listbox']//*[@class='k-icon k-i-arrow-60-down']"));
        IWebElement InterventionsArrowSelect => _driver.FindElement(By.XPath(".//*[@id='InterventionId_listbox']/li[1]"));
        IWebElement InterventionExplanatoryNote => _driver.FindElement(By.XPath(".//*[@id='ExplanatoryNote']"));
        IWebElement InterventionTickMark => _driver.FindElement(By.XPath(".//*[@id='programme_intervention_grid']//*[@class='k-button k-button-icontext k-primary k-grid-update']"));
        IWebElement CoFinancingTab => _driver.FindElement(By.Id("programmeEditTabStrip-tab-10"));
        IWebElement CoFinancingNew => _driver.FindElement(By.XPath(".//*[@id='cofinance_grid']//*[text()='New']"));
        IWebElement CoFinancingPartnerArrow => _driver.FindElement(By.XPath(".//*[@aria-owns='OrganisationId_listbox']//*[@class='k-icon k-i-arrow-60-down']"));
        IWebElement CoFinancingPartnerSearchBox => _driver.FindElement(By.XPath("(.//*[@role='searchbox'])[2]"));

        IWebElement CoFinancingPartnerSelect => _driver.FindElement(By.XPath(".//*[@id='OrganisationId_listbox']/li[2]"));
        IWebElement CoFinancingTypeSearchBox => _driver.FindElement(By.XPath("(.//*[@role='searchbox'])[3]"));
        IWebElement CoFinancingTypeArrow => _driver.FindElement(By.XPath(".//*[@aria-owns='Type_listbox']//*[@class='k-icon k-i-arrow-60-down']"));
        IWebElement CoFinancingTypeSelect => _driver.FindElement(By.XPath(".//*[@id='Type_listbox']//li[2]"));
        IWebElement CoFinancingAmountUSD => _driver.FindElement(By.XPath(".//*[@id='Amount']/preceding-sibling::input"));
        IWebElement CoFinancingAmountUSDValue => _driver.FindElement(By.XPath(".//*[@id='Amount']"));
        IWebElement CoFinancingDate => _driver.FindElement(By.XPath("//input[@id='Date']"));

        IWebElement CoFinancingSaveButton => _driver.FindElement(By.XPath(".//*[@id='CofinanceCreateWindow']//button[@role='button']"));

        IWebElement InvestorPaymentsTab => _driver.FindElement(By.Id("programmeEditTabStrip-11"));
        IWebElement InvestorPaymentNewButton => _driver.FindElement(By.XPath(".//*[@id='donor_payment_grid']//*[text()='New']"));


        IWebElement ProgrammeUploadDocumentTab => _driver.FindElement(By.Id("programmeEditTabStrip-tab-13"));
        IWebElement ProgrammeUploadDocumentNewButton => _driver.FindElement(By.XPath(".//*[@id='programme_documents_grid']//*[text()='New']"));
        IWebElement ProgrammeUploadDocumentsDocTypeArrow => _driver.FindElement(By.XPath(".//*[@id='DocumentTypeId_label']/following-sibling::span//span[@class='k-icon k-i-arrow-60-down']"));
        IWebElement ProgrammeUploadDocumentsDocTypeSelect => _driver.FindElement(By.XPath(".//ul[@id='DocumentTypeId_listbox']/li[2]"));
        IWebElement ProgrammeUploadDocumentsSubTypeArrow => _driver.FindElement(By.XPath(".//*[@id='DocumentSubtypeId_label']/following-sibling::span//span[@class='k-icon k-i-arrow-60-down']"));
        IWebElement ProgrammeUploadDocumentsSubTypeSelect => _driver.FindElement(By.XPath(".//ul[@id='DocumentSubtypeId_listbox']/li[2]"));
        IWebElement ProgrammeUploadDocumentsSelectFiles => _driver.FindElement(By.XPath(".//*[text()='Files']/following-sibling::div//div[@aria-label='Select files...']"));
        IWebElement ProgrammeUploadDocumentsSaveButton => _driver.FindElement(By.XPath(".//*[text() ='Files']/parent::div/following-sibling::div//*[@class='btn btn-primary']"));






        public void ClickKeyInformationTab()

        {
            Thread.Sleep(1000);
            KeyInformationTab.Click();
        }


        public void EnterInvestmentValue()
        {


            ExpectedCmtForInvestment.Click();

            ExpectedCmtForInvestmentValue.Clear();
            ExpectedCmtForInvestment.Click();

            ExpectedCmtForInvestmentValue.SendKeys("6666666");


        }

        public void EnterCoFinancingValue()
        {
            ExpectedCoFinancing.Click();

            ExpectedCoFinancingValue.Clear();
            ExpectedCoFinancing.Click();
            ExpectedCoFinancingValue.SendKeys("8888888");

        }


        public void ClickProgrammeSaveButton()
        {
            ProgrammeSaveButton.Click();
        }




        public void ProcessTrackerCreateStage(string ProcessTrackerStagename)
        {

            ProcessTrackerTab.Click();
            ProcessTrackerNewButton.Click();
            ProcessTrackerCreateStageName.Click();
            ProcessTrackerCreateStageName.SendKeys(ProcessTrackerStagename);
            Thread.Sleep(500);
            ProcessTrackerCreateStageSaveButton.Click();
            /*if(_driver.FindElement(By.XPath(".//*[@id='errorTemplate']")).Displayed)
            {
                ProcessTrackerCreateStageName.SendKeys(ProcessTrackerStagename);
            }*/


        }
       /* public Boolean ProcessTrackerEditStageVerifyProgrammeLink(string ProcessTrackerStagename)
        {


            ProcessTrackerStageEditIcon(ProcessTrackerStagename).Click();
            string ProgrammeLinkText = StageProgrammeLink.Text;
            StageProgrammeLink.Click();
            string ProgrammeName = _driver.FindElement(By.XPath(".//*[@id='Programme_Name']")).GetAttribute("value");
            Boolean validation = ProgrammeLinkText.Equals(ProgrammeName);
            return validation;

        }*/

        public void ProcessTrackerEditStageDetails(string ProcessTrackerStagename)
        {
            Thread.Sleep(3000);
            ProcessTrackerStageEditIcon(ProcessTrackerStagename).Click();
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            if (wait.Until(ExpectedConditions.AlertIsPresent()) != null)
            {
                _driver.SwitchTo().Alert().Accept();
            }
              
            StageOwnerArrow.Click();
            StageOwnerArrowSelection.Click();
          
           // SwitchToFrame(StageDescription, 1, "Test description entered by automation script");
            StageWorkItemTab.Click();
            StageWorkItemNew.Click();
            Thread.Sleep(3000);
            StageWorkItemCreateName.Click();
            Thread.Sleep(100);
            StageWorkItemCreateName.SendKeys("WI Created from Process Tracker");
            StageWorkItemTypeArrow.Click();
           
            Actions action = new Actions(_driver);
            action.MoveToElement(StageWorkItemTypeSelect).Build();
         
            action.SendKeys(Keys.Tab);
            Thread.Sleep(1000);
            StageWorkItemSaveButton.Click();
            ProcessTrackerDiscussionTab.Click();
            string ProcessTrackerDiscussionAddAComment = ".//*[@aria-label='Add a comment...']";

            SwitchToFrame(ProcessTrackerDiscussionAddAComment, 2, "Test discussion entered by automation script");
            ProcessTrackerDiscussionAddNewCommentButton.Click();
            ProcessTrackerStageSaveButton.Click();
            Thread.Sleep(1000);
            ProcessTrackerStageDetailsTab.Click();
            StageProgrammeLink.Click();

        }



        public void SwitchToFrame(string XpathofElement, int index, string EnterString)
        {

            _driver.SwitchTo().Frame(_driver.FindElement(By.XPath($"(.//iframe[@class='k-content'])[{index}]")));
           IWebElement FrameElement= _driver.FindElement(By.XPath(XpathofElement));
                
                FrameElement.Click();
            FrameElement.SendKeys(EnterString);
            _driver.SwitchTo().DefaultContent();
        }



        public void RiskCreateAndEdit()
        {

            Thread.Sleep(2000);
            RiskTab.Click();
            RiskNewButton.Click();
            // RiskMatrixButton.Click();

            //RiskMatrixCloseButton.Click();
            Thread.Sleep(2000);
            RiskNameField.SendKeys("Automation1234");
            RiskStageArrow.Click();
            Actions tabaction = new Actions(_driver);
            tabaction.MoveToElement(RiskStageSelection).Build();

            tabaction.SendKeys(Keys.Tab);
           

           
            
            new Actions(_driver).DragAndDropToOffset(RiskLikelihoodSlider, 120, 0).Build().Perform();
            
            new Actions(_driver).DragAndDropToOffset(RiskImpactSlider, 40, 0).Build().Perform();
            
            new Actions(_driver).DragAndDropToOffset(RiskLikelihoodSlider, 120, 0).Build().Perform();
            RiskSaveButton.Click();
        }

        public void KanbanCreate()
        {
            Thread.Sleep(2000);
            KanbanTab.Click();
            KanbanPlusIcon.Click();
            KanbanName.SendKeys("Automation Kanban1");
            /*Actions actioncursor = new Actions(_driver);
            //KanbanStageArrow.Click();
            //Thread.Sleep(2000);
            actioncursor.MoveToElement(KanbanStageSelect).Build();
            actioncursor.SendKeys(Keys.Tab);
            
            Actions action1 = new Actions(_driver);
            KanbanTypeArrow.Click();
            action1.MoveToElement(KanbanTypeSelect).Build();
            action1.SendKeys(Keys.Tab);
            */

            KanbanSaveButton.Click();
            Thread.Sleep(2000);
            Actions action = new Actions(_driver);
            action.DragAndDrop(KanbanNotStarted, KanbanInProgress).Perform();
            action.DragAndDrop(KanbanNotStarted, KanbanWaiting).Perform();
            action.DragAndDrop(KanbanWaitingFirstRecord, KanbanCompleted).Perform();

            Thread.Sleep(2000);
          }
        public void ProjectCreate()
         {
            ProjectsTab.Click();
            ProjectNewButton.Click();
            Thread.Sleep(1000);
            ProjectCreateNewName.Click();

            ProjectCreateNewName.SendKeys("Automated test created the project");
            ProjectProcessTemplateArrow.Click();
            ProjectProcessTemplateSelect.Click();
            ProjectCreateNewSaveButton.Click();
            Thread.Sleep(5000);
        }



        public void InterventionCreate()
        {
            InterventionsTab.Click();
            InterventionNewButton.Click();
            InterventionTypeArrow.Click();
            InterventionTypeSelection.Click();
            InterventionsArrow.Click();
            InterventionsArrowSelect.Click();
            InterventionExplanatoryNote.SendKeys("Test notes");
            Thread.Sleep(2000);
            InterventionTickMark.Click();

        }



        public void CoFinancingCreate()
        {
            Thread.Sleep(2000);
            CoFinancingTab.Click();
            CoFinancingNew.Click();
            Thread.Sleep(2000);
            //CoFinancingPartnerArrow.Click();

           
            CoFinancingPartnerArrow.Click();
            CoFinancingPartnerSelect.Click();
            //CoFinancingPartnerSearchBox.Click();
           // CoFinancingPartnerSearchBox.SendKeys("WB: World Bank");
            Thread.Sleep(1000);
           //   CoFinancingPartnerSearchBox.SendKeys(Keys.Tab);
           Actions tabaction = new Actions(_driver);
            //tabaction.SendKeys("WB");
           // tabaction.MoveToElement(CoFinancingPartnerSelect).Build().Perform();

           tabaction.SendKeys(Keys.Tab);
          
           
        
            CoFinancingTypeArrow.Click();
            CoFinancingTypeSelect.Click();
            CoFinancingAmountUSD.Click();
            CoFinancingAmountUSDValue.Clear();
            CoFinancingAmountUSD.Click();
            CoFinancingAmountUSDValue.SendKeys("200000");
            CoFinancingDate.SendKeys("01/03/2022");
            CoFinancingSaveButton.Click();
           

        }



        public void ProgrammeDocumentUpload()
        {
            Thread.Sleep(1000);
            ProgrammeUploadDocumentTab.Click();
            Thread.Sleep(1000);
            ProgrammeUploadDocumentNewButton.Click();
            Thread.Sleep(1000);
            ProgrammeUploadDocumentsDocTypeArrow.Click();
            Thread.Sleep(1000);
            ProgrammeUploadDocumentsDocTypeSelect.Click();
            ProgrammeUploadDocumentsSubTypeArrow.Click();
            ProgrammeUploadDocumentsSubTypeSelect.Click();
            string filenamenew = System.IO.Directory.GetParent(@"../../../").FullName;
            string fileName = filenamenew + "\\Resources\\SSMyClaims.xls";


            ProgrammeUploadDocumentsSelectFiles.Click();
            /* _driver.FindElement(By.Id("Files"), TimeSpan.).SendKeys(fileName);

             IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
             // Setting value for "style" attribute to make textbox visible
             js.ExecuteScript("document.getElementById('modal-hidden-file-uploading-input').style.visibility = 'visible'");
             js.ExecuteScript("arguments[0].style.display='block';", ProgrammeUploadDocumentsSelectFiles);
             FileUploadInput.SendKeys(fileName);*/

            AutoItX3 autoit = new AutoItX3();

              autoit.WinActivate("Open");
              Thread.Sleep(5000);
              autoit.Send(fileName);
              Thread.Sleep(3000);
              autoit.Send("{ENTER}");
              Thread.Sleep(1000);



            ProgrammeUploadDocumentsSaveButton.Click();
            Thread.Sleep(1000);
        }



    }
    }

