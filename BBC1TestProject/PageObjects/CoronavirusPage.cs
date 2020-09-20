using BBC1TestProject.Hooks;
using BBC1TestProject.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BBC1TestProject.PageObjects
{
    class CoronavirusPage 
    {
        IWebDriver driver;
        public CoronavirusPage()
        {
            this.driver = Hooks1.driver;
        }

        Waits Waits = new Waits(); /// for example

        IWebElement yourCoronavirusStoryBtn =>
            driver.FindElement(By.XPath("//ul[contains(@class, 'secondary-sections')]//span[contains(text(), 'Your Coronavirus Stories')]"));

        public void ClickOnYourCoronavirusStoryBtn()
        {
            Waits.WaitForElement(driver, yourCoronavirusStoryBtn).Click(); //// example
        }
    }
    
}

