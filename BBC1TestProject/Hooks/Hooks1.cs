using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BBC1TestProject.Hooks
{
    [Binding]
    public class Hooks1
        
    {
        public static IWebDriver driver;

        //[BeforeFeature]
        //public static void BeforeFeature()
        //{
        //}

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }

        //[AfterFeature]
        //public static void AfterFeature()
        //{
        //}
    }
}
