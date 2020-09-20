using BBC1TestProject.Hooks;
using BBC1TestProject.Utilities;
using Google.Protobuf;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BBC1TestProject.Forms
{
    class Form
    {
        IWebDriver driver;
        public Form()
        {
            this.driver = Hooks1.driver;
        }

        Waits Waits = new Waits(); /// for example
        private string inputs;
        //public void FillForm(Dictionary<string, string> values)
        //{
        //    foreach (KeyValuePair<string, string> inputField in values)
        //    {
        //        inputs = inputField.Key;
        //        Assert.IsTrue(inputs.Contains("Tell us your story") || inputs.Equals("I am over 16 years old")); ///+

        //        if (driver.FindElement(By.XPath("//div[contains(@class, 'content-container')]//*[contains(@area-label,'" + inputs +"')]")).Count == 0)
        //        {
        //            IWebElement checkboxPath = driver.FindElement(By.XPath("//div[contains(@class, 'content-container')]//*[contains(text(),'" + inputs + "')]"));
        //            if (inputField.Value == "Yes")
        //                checkboxPath.Click();
        //        }
        //        else
        //        {
        //            IWebElement fieldPath = driver.FindElement(By.XPath("//div[conrains(@class, 'content-container')]//*[contains(@area-label,'" + inputs + "')]"));
        //            fieldPath.SendKeys(inputField.Value);
        //        }
        //    }
        //}
    }
}
