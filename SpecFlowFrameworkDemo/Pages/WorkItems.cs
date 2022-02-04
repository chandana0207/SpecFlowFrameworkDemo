using System;
using OpenQA.Selenium;
using System.Text;

namespace SpecFlowFrameworkDemo.Pages
{
    class  WorkItems : PageObjects
    {
        private readonly IWebDriver _driver;
        public WorkItems(IWebDriver webDriver) : base(webDriver)
        {
            _driver = webDriver;

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }


        public IWebElement QuickLinks => _driver.FindElement(By.XPath("/html/body/div[2]/nav/div[2]/div/ul/li[11]/a/i"));
        // public IWebElement SignInButton => _driver.FindElement(By.Id("idSIButton9"));
        public IWebElement WorkItemsLink => _driver.FindElement(By.XPath("/html/body/div[2]/nav/div[2]/div/ul/li[11]/ul/li[5]/a"));
        public IWebElement NewButton => _driver.FindElement(By.XPath(" //*[@id='workItemGrid']/div[1]/a[1]"));
        public IWebElement Name => _driver.FindElement(By.Id("Name"));
        public IWebElement PPClick => _driver.FindElement(By.CssSelector("div[data-container-for='ContainerTypeSelector'] .k-select"));
        public IWebElement PPSelect => _driver.FindElement(By.CssSelector("#ContainerTypeSelector-list li[data-offset-index='0']"));
        public IWebElement ContainerClick => _driver.FindElement(By.CssSelector("div[data-container-for='Container'] .k-select"));

        public IWebElement ContainerSelect => _driver.FindElement(By.CssSelector("#Container_listbox li[data-offset-index='7']"));
        public IWebElement StageClick => _driver.FindElement(By.CssSelector("div[data-container-for='StageId'] .k-select"));
        public IWebElement StageSelect => _driver.FindElement(By.CssSelector("#StageId_listbox li[data-offset-index='0']"));

        public IWebElement TypeClick => _driver.FindElement(By.CssSelector("div[data-container-for='TypeId'] .k-select"));

        public IWebElement TypeSelect => _driver.FindElement(By.CssSelector("#TypeId_listbox li[data-offset-index='0']"));
        public IWebElement SaveButton => _driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div/form/div[2]/div/div[2]/span[2]/button[2]"));



        public void WorkItemEnter(string name, string pptype, string containertype, string stage, string type)
        { 
        
        
        }





    }
}
