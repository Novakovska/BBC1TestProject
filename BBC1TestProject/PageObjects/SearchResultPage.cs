using BBC1TestProject.Hooks;
using BBC1TestProject.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BBC1TestProject.PageObjects
{
    class SearchResultPage
    {
        IWebDriver driver;
        public SearchResultPage()
        {
            this.driver = Hooks1.driver;
        }
        Waits Waits = new Waits();

        IWebElement firstResultArticle =>
            driver.FindElement(By.XPath("//div[@width ='compact']/ul/li[1]//p//span"));


        public string GetFirstResultArticleText()
        {
            return firstResultArticle.Text;
        }

    }
}
