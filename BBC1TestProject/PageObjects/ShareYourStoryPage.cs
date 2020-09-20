using BBC1TestProject.Hooks;
using BBC1TestProject.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BBC1TestProject.PageObjects
{
    class ShareYourStoryPage
    {
        IWebDriver driver;
        public ShareYourStoryPage()
        {
            this.driver = Hooks1.driver;
        }
        Waits Waits = new Waits(); 

        IWebElement submitBtn =>
            driver.FindElement(By.XPath("//button[@class='button']"));

        IWebElement storyField =>
            driver.FindElement(By.XPath("//textarea"));

        IWebElement nameField =>
            driver.FindElement(By.XPath("//input[@placeholder='Name']"));

        IWebElement over16checkbox =>
            driver.FindElement(By.XPath("// span//p[contains(text(), 'I am over 16')]/../../../input"));

        IWebElement acceptPolicycheckbox =>
            driver.FindElement(By.XPath("// span//p[contains(text(), 'I accept')]/../../../input"));



        public void ClickOnSubmitBtn()
        {
            Waits.WaitForElement(driver, submitBtn).Click();
       
        }
        public string GetPageURL => driver.Url;

        public void EnterSomeTextToStoryField(string sometext)
        {
            storyField.SendKeys(sometext);

        }
        public void EnterName(string name)
        {
            nameField.SendKeys(name);

        }
        public void AdmitIAmOver16Checkbox()
        {
            Waits.WaitForElement(driver, over16checkbox).Click();

        }
        public void AdmitIAcceptCheckbox()
        {
            Waits.WaitForElement(driver, acceptPolicycheckbox).Click();

        }
    }
}
