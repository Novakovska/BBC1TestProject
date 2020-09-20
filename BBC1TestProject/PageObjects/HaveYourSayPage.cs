using BBC1TestProject.Hooks;
using BBC1TestProject.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace BBC1TestProject.PageObjects
{
    class HaveYourSayPage
    {
        IWebDriver driver;
        public HaveYourSayPage()
        {
            this.driver = Hooks1.driver;
        }
        Waits Waits = new Waits();

        IWebElement howToShareBtn =>
        driver.FindElement(By.XPath("//h3[contains(text(), 'How to share with BBC News')]"));

        public void ClickOnHowToShareBtn()
        {
            IJavaScriptExecutor ex = (IJavaScriptExecutor)driver;
            ex.ExecuteScript("arguments[0].click();", howToShareBtn);

        }
    }
}
