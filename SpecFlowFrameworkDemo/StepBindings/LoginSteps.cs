using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowFrameworkDemo.Pages;
using SpecFlowFrameworkDemo.Resources;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowFrameworkDemo.Steps
{
    [Binding]
    class LoginSteps
    {
        public static int pnamenumber;
        LoginPage _loginPage = null;
        CreateWorkItem _createWorkItem = null;
        CreateProgramme _createProgramme = null;
        PrgEditKIPage _prgEditKIPage = null;
        Grants _grantsPage = null;
        public static string  pname;
        public LoginSteps(IWebDriver driver)
        {
            _loginPage = new LoginPage(driver);
            _createWorkItem = new CreateWorkItem(driver);
            _createProgramme = new CreateProgramme(driver);
            _prgEditKIPage = new PrgEditKIPage(driver);
            _grantsPage = new Grants(driver);
            
        }



        [Given("I'm on the Portfolio Dashboard")]
        public void LoginAndVerifyTitle()
        {
            _loginPage.Navigate("https://tpon-orbit.staging.intouch-business.com/");
            var userData = ExcelDataReader.GetTestData("Admin", "LoginAdminTest");
            _loginPage.Login(userData.Username, userData.Password);
            _loginPage.ClickLoginButton();
            _loginPage.ClickStaySignIn();
            _loginPage.VerifyPageTitle().Should().Be("Dashboard");

        }
     

        [Given(@"I click Quick Links menu and tap on Work Items link")]
        public void GivenIClickQuickLinksMenuAndTapOnWorkItemsLink()
        {

            _loginPage.NavigateToWorkItems();
        }
        
        [Given(@"I click New button on All Work Items Page")]
        public void GivenIClickNewButton()
        {
            _createWorkItem.ClickNewButton();
        }

        [Given(@"I Enter the Name, Programme/Project, Container, stage and Type on the Create Work Item pop-up box")]
        public void GivenIEnterTheNameProgrammeProjectContainerStageAndType()
        {
            Thread.Sleep(1000);
            var programmedetails = ExcelDataReader.GetProgrammeDetails("ProgrammeDetails", "ProgrammeDetails");
            Thread.Sleep(1000);
            Random rnd = new Random();
            pnamenumber = rnd.Next(1, 999);
            pname = programmedetails.ProgrammeName + pnamenumber;
            _createWorkItem.EnterDataInName(pname);

            _createWorkItem.SelectProjectProgramme();
            _createWorkItem.ContainerDropDown();
            _createWorkItem.ClickStageDropDown();
            _createWorkItem.ClickTypeDropDown();



        }

        [Given(@"I click on Save button")]
        public void GivenIClickOnSaveButton()
        {


            _createWorkItem.ClickSaveButton();
        }

        [Given(@"I verify the Success Notification")]
        public void GivenIVerifyTheSuccessNotification()
        {
            _createWorkItem.VerifySuccessPopUp().Should().Be("Work Item Created Successfully.");
      
         }


        [Given(@"I Click on Name Filter")]
        public void GivenIClickOnNameFilter()
        {
            _createWorkItem.NameFilterClick();
            Thread.Sleep(1000);
        }

        [Given(@"I enter the WIName Text in the filter textbox")]
        public void GivenIEnterTheWINameTextInTheFilterTextbox()
        {
          
            _createWorkItem.EnterFilterText(pname);

        }

        [Given(@"I click Filter Button")]
        public void GivenIClickFilterButton()
        {
            _createWorkItem.ClickFilterButton();  
        }

        [Given(@"I click Editlink icon to open the work item to be edited")]
        public void GivenIClickEditlinkIcon()
        {
            Thread.Sleep(1000);
            _createWorkItem.ClickEditIconLink();
        }

        [Given(@"I select the Status")]
        public void GivenISelectTheStatus()
        {
            _createWorkItem.WIStatusDropDown();
        }

        [Given(@"I select the Owner")]
        public void GivenISelectTheOwner()
        {
            _createWorkItem.WIOwnerDropDown();
            
        }

        [Given(@"I select the priority")]
        public void GivenISelectThePriority()
        {
            _createWorkItem.WIPriorityDropDown();
        }

        [Given(@"I enter the dates")]
        public void EnterWorkItemDates()
        {
            Thread.Sleep(1000);
       
            var workitemdates = ExcelDataReader.GetWorkItemDates("WorkItemDates", "Dates");
            _createWorkItem.EnterDates(workitemdates.TStartDate, workitemdates.TEndDate, workitemdates.AStartDate, workitemdates.AEndDate);
        }


        [Given(@"I enter the description")]
         public void GivenIEnterTheDescription()
         {
             _createWorkItem.EnterWIDescription();
         }



        
           [Given(@"I enter the approver")]
        public void IEnterTheApprover()
       {
           _createWorkItem.ClickPlustoEnterApprover().Should().Be("Approvals");
            _createWorkItem.ClickApproverSubmit();

       }
        


        
                [Given(@"I select the internal user")]
                public void GivenISelectTheInternalUser()
                {
                    _createWorkItem.SelectInternalUser();
                   _createWorkItem.ClickWISaveButton();

                }


        [Given(@"I select the external user")]
        public void GivenISelectTheExternalUser()
        {
            _createWorkItem.SelectExternalUser();

        }



        [Given(@"I click the Discussion Tab and enter comment")]
        public void ClickDiscussionTabAndEnterComment()
        {
            _createWorkItem.ClickDiscussionTab();
            _createWorkItem.AddComment();

        }

        [Given(@"I click Conditions tab and a condition")]
        public void ClickConditionAndEnterCondition()
        {
            _createWorkItem.ConditionsTab();

        }

        [Given(@"I click Issues tab and create an issue.")]
        public void ClickIssuesTabAndCreateNewIssue()
        {
            _createWorkItem.IssuesTab();

        }

        [Given(@"I select a file to upload")]
        public void SelectDocument()
        {
            _createWorkItem.DocumentSelection();

        }







        [Given(@"I Click Save Button to update the changes made.")]
        public void GivenIClickSaveButton()
        {
            _createWorkItem.ClickWISaveButton();
        }

         

        [Given(@"I click Programmes Menu Link")]
        public void GivenIClickProgrammesMenuLink()
        {
            _createProgramme.ClickPrgMenuButton();
        }


        [Given(@"I click New button on all programmes page")]
        public void GivenIClickNewButtonOnAllProgrammesPage()
        {
            _createProgramme.ClickNewButton();
        }

        [Given(@"I enter programme name,code,start date, end date,Investor currency and process template in the create programme pop-up")]
        public void GivenIEnterProgrammeNameCodeStartDateEndDateInvestorCurrencyAndProcessTemplateInTheCreateProgrammePop_Up()
        {
            var programmedetails = ExcelDataReader.GetProgrammeDetails("ProgrammeDetails", "ProgrammeDetails");
            Thread.Sleep(1000);
            Random rnd = new Random();
            pnamenumber = rnd.Next(1, 999);

            _createProgramme.EnterProgrammeDetails(programmedetails.ProgrammeName+ pnamenumber, programmedetails.ProgrammeCode + pnamenumber, programmedetails.ProgrammeStartDate, programmedetails.ProgrammeEndDate);

        }

        [Given(@"I click save button")]
        public void GivenIClickProgrammeSaveButton()
        {
            _createProgramme.ClickSaveButton();
        }



        [Then(@"I verify the success notification")]
        public void ThenIVerifyTheSuccessNotification()
        {
            _createProgramme.VerifyPrgSuccessPopUp().Should().Be("Programme Created Successfully.");
        }

        [Given(@"I click filter icon  on Name column and enter the text and click filter button")]
        public void GivenIClickFilterButtonOnNameColumn()
        {
            var programmedetails = ExcelDataReader.GetProgrammeDetails("ProgrammeDetails", "ProgrammeDetails");
           
            _createProgramme.ClickOnNameFilter(programmedetails.ProgrammeName);
          
            
        }

        
        [Given(@"I click edit icon to open the programme")]
        public void GivenIClickEditIconToOpenTheProgramme()
        {
            _createProgramme.ClickOnProgrammeEditIcon();
        }

        [Given(@"I click on Key Information tab")]
        public void GivenIClickOnKeyInformationTab()
        {
            _prgEditKIPage.ClickKeyInformationTab();
        }

        [Given(@"I enter value for the Expected Commitment for Investment")]
        public void GivenIEnterValueForTheExpectedCommitmentForInvestment()
        {
            _prgEditKIPage.EnterInvestmentValue();
           

        }

         [Given(@"I enter Expected CoFinancing for Investment")]
          public void GivenIEnterValueForTheCoFinancingForInvestment()
          {

              _prgEditKIPage.EnterCoFinancingValue();

          }
        

        [Given(@"I click programme save button")]
        public void ClickOnProgrammeSaveButton()
        {
            _prgEditKIPage.ClickProgrammeSaveButton();
        }

        [Given(@"I click ProcessTracker tab and create and edit stage")]
        public void GivenIClickProcessTrackerTabAndCreateAndEditStage()
        {
            var programmedetails = ExcelDataReader.GetProgrammeDetails("ProgrammeDetails", "ProgrammeDetails");
            Thread.Sleep(1000);
            Random rnd = new Random();
            pnamenumber = rnd.Next(1, 999);
            string PgmName = programmedetails.ProgrammeName + pnamenumber;
            _prgEditKIPage.ProcessTrackerCreateStage(PgmName);
          //  _prgEditKIPage.ProcessTrackerEditStageVerifyProgrammeLink(PgmName).Should().BeTrue();
            _prgEditKIPage.ProcessTrackerEditStageDetails(PgmName);


        }



        [Given(@"I click Risk tab then create a risk and edit risk")]
        public void GivenIClickRiskTabThenCreateARiskAndEditRisk()
        {
            _prgEditKIPage.RiskCreateAndEdit();
        }

        [Given(@"I click Kanban Tab then click plus icon to cerate a work item")]
        public void GivenIClickKanbanTabThenClickPlusIconToCerateAWorkItem()
        {
            _prgEditKIPage.KanbanCreate();
        }

        [Given(@"I click Projects Tab then click on New button to create a new project")]
        public void GivenIClickProjectsTabThenClickOnNewButtonToCreateANewProject()
        {
            _prgEditKIPage.ProjectCreate();
        }



        [Given(@"I click Interventions Tab then click on New button to create a new intervention")]
        public void GivenIClickInterventionsTabThenClickOnNewButtonToCreateANewIntervention()
        {
            _prgEditKIPage.InterventionCreate();
        }

        [Given(@"I click cofinancing tab and create a new cofinance")]
        public void GivenIClickCofinancingTabAndCreateANewCofinance()
        {
            _prgEditKIPage.CoFinancingCreate();
        }


        [Given(@"I click Programme Upload tab and upload the document")]
        public void GivenIClickProgrammeUploadTabAndUploadTheDocument()
        {
            _prgEditKIPage.ProgrammeDocumentUpload();
        }



        [Given(@"I click Partner Menu Link and create a new partner with partner type being Investor")]
        public void GivenIClickPartnerMenuLink()
        {
            var programmedetails = ExcelDataReader.GetProgrammeDetails("ProgrammeDetails", "ProgrammeDetails");
            Thread.Sleep(1000);
            Random rnd = new Random();
            pnamenumber = rnd.Next(1, 999);

            _grantsPage.CreatePartner( programmedetails.ProgrammeName + pnamenumber, pnamenumber.ToString()+"A");
            
        }

        

        [Given(@"I create the grant and approve it")]
        public void GivenICreateTheGrantAndApproveIt()
        {
            _grantsPage.CreateGrant();


            

           
        }

        [Given(@"I click allocation tab to create a new allocation and I approve it")]
        public void GivenIClickAllocationTabToCreateANewAllocationAndIApproveIt()
        {
            _grantsPage.CreateAllocation();
        }

       

        [Given(@"I click on Adjustment tab to create an adjustment and approve it")]
        public void GivenIClickOnAdjustmentTabToCreateAnAdjustmentAndApproveIt()
        {
            _grantsPage.CreateAdjustment();
        }




    }



}




