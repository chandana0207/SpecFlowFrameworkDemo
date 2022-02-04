using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowFrameworkDemo.Support
{
	using System;
	using BoDi;
	using System.IO;
	using OpenQA.Selenium;
	using TechTalk.SpecFlow;
    using SpecFlowFrameworkDemo.Steps;
    using SpecFlowFrameworkDemo.Pages;
    using SpecFlowFrameworkDemo.Resources;
    using NUnit.Framework;
    using AventStack.ExtentReports.Reporter;
    using AventStack.ExtentReports;

    [Binding]


		public class Hooks
		{
			private static IObjectContainer _objectContainer;
			private static IWebDriver _driver;
			private static DriverFactory _driverFactory;
		    static AventStack.ExtentReports.ExtentReports extent;
		    static AventStack.ExtentReports.ExtentTest feature;
		   AventStack.ExtentReports.ExtentTest scenario,step;

			static string ReportPath = System.IO.Directory.GetParent(@"../../../").FullName + Path.DirectorySeparatorChar + "Results"+Path.DirectorySeparatorChar+"Results_"+DateTime.Now.ToString("ddMMyyyy HHmmss");
		  
		LoginPage _loginPage = new LoginPage(_driver);
		 

		public  Hooks(IObjectContainer objectContainer)
			{
				_objectContainer = objectContainer;
			}
		



		// @TODO: DriverFactory for multi browser parallel execution
		[BeforeTestRun]
			public static void BeforeTestRun()
			{
				_driverFactory = new DriverFactory();
				Directory.CreateDirectory(Path.Combine("..", "..", "TestResults"));
                string filepath = "Report_"+ DateTime.Now.ToString("ddMMyyyy HHmmss")+".html";

				ExtentHtmlReporter htmlreport = new ExtentHtmlReporter(@"C:\Users\chandana.kotagiri\Downloads\SpecFlowFrameworkDemo-master\SpecFlowFrameworkDemo-master\SpecFlowFrameworkDemo\Results" + Path.DirectorySeparatorChar + "Results_" + DateTime.Now.ToString("ddMMyyyy HHmmss")+@"\"+filepath);
			    extent = new AventStack.ExtentReports.ExtentReports();
			    extent.AttachReporter(htmlreport);

			 }
		[BeforeFeature]
		public static void BeforeFeature(FeatureContext context)
		{
			_driver = _driverFactory.CreateDriver();
			_driver.Manage().Window.Maximize();
			feature = extent.CreateTest(context.FeatureInfo.Title);
			//_objectContainer.RegisterInstanceAs(_driver);
			_driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

		}


		[BeforeScenario(Order = 1)]
		

			public void BeforeScenario(ScenarioContext Context)
			{

			_objectContainer.RegisterInstanceAs(_driver);
			scenario = feature.CreateNode(Context.ScenarioInfo.Title);

		     }


		[BeforeStep]
		public void BeforeStep()
        {
			step = scenario;

        }
		[AfterStep]
		public void AfterStep(ScenarioContext context)
		{
			if(context.TestError == null)
            {
				step.Log(Status.Pass, context.StepContext.StepInfo.Text);
            }
			else if(context.TestError != null)
            {
				step.Log(Status.Fail, context.StepContext.StepInfo.Text);

			}


		}



		[AfterScenario(Order = 2)]

		public void AfterScenario(ScenarioContext scenarioContext)
		{



			ITakesScreenshot screenshotDriver = _driver as ITakesScreenshot;
			Screenshot screenshot = screenshotDriver.GetScreenshot();

			string filenamenew = System.IO.Directory.GetParent(@"../../../").FullName;
			
;			screenshot.SaveAsFile(Path.Combine(filenamenew + "\\ResultsScreenshot\\" + $"{scenarioContext.ScenarioInfo.Title}+{DateTime.Now.ToString("ddMMyyyy HHmmss")}.png"), ScreenshotImageFormat.Png);
			

			
			extent.Flush();
		}


	[AfterFeature]
		public static void AfterFeature(ScenarioContext scenarioContext)
		{
			_driver.Navigate().GoToUrl("https://tpon-orbit.staging.intouch-business.com/");
			

		}




		[AfterTestRun]
		    public static void AfterTestRun()
		    {
			_driver?.Dispose();
		    }

	}
}
