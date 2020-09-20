using BBC1TestProject.Hooks;
using BBC1TestProject.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BBC1TestProject.PageObjects
{
    class HomePage 
    {
        IWebDriver driver;
        public HomePage()
        {
            this.driver = Hooks1.driver;
        }
        Waits Waits = new Waits(); 

        IWebElement newsBtn =>
            driver.FindElement(By.XPath("//a[@class='module__title__link tag tag--news']"));

        public void ClickOnNewsBtn()
        {
            Waits.WaitForElement(driver, newsBtn).Click(); 
        }

        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://www.bbc.com/");
        } 
    }
}
 