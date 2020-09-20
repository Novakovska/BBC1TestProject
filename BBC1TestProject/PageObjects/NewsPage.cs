using BBC1TestProject.Hooks;
using BBC1TestProject.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BBC1TestProject.PageObjects
{
    class NewsPage
    {
        IWebDriver driver;

        public NewsPage()
        {
            this.driver = Hooks1.driver;
        }
        Waits Waits = new Waits(); /// for example

        IWebElement coronavirusBtn =>
        driver.FindElement(By.XPath("//div[contains(@class, 'navigation')]//span[contains(text(), 'Coronavirus')]")); 

        IWebElement maybeLaterBtn =>
        driver.FindElement(By.XPath("//button[@class='sign_in-exit']")); 

        IWebElement headlineArticle =>
        driver.FindElement(By.XPath("//div[contains(@class, 'block@m')]/div/a/h3[contains(@class, 'promo-heading__title')]"));

        IWebElement categoryLink =>
        driver.FindElement(By.XPath("//div[contains(@class, 'none gs')]/ul//a/span[@aria-hidden='true']")); 

        IEnumerable <IWebElement> secondaryArticlesList =>
            driver.FindElements(By.XPath("//div[contains(@class, 'secondary-item')]//h3")); 

        IWebElement searchField =>
        driver.FindElement(By.XPath("//input[@id='orb-search-q']"));

        IWebElement searchBtn =>
        driver.FindElement(By.XPath("//button[@id='orb-search-button']"));

        

        public void ClickOnCoronavirusBtn()
        {
            coronavirusBtn.Click();
        }

        public void ClickOnMaybeLaterBtnBtn()
        {
            Waits.WaitForElement(driver, maybeLaterBtn).Click();
        }

        public string GetTextOfTitleOfMainArticle()
        {
            return Waits.WaitForElement(driver, headlineArticle).Text;
        }

        public void ClickOnSearchBtn()
        {
            searchBtn.Click();
        }


        public string GetCategoryLinkText()
        {
            return categoryLink.Text;
        }

        public void Search()
        {
            searchField.SendKeys(GetCategoryLinkText());
            ClickOnMaybeLaterBtnBtn();
            ClickOnSearchBtn();

        }

        public List<string> GetSecondaryArticleTitleList()
        {
            List<string> myList = new List<string>();
            foreach (IWebElement webElement in secondaryArticlesList)
            {
                string elementText = webElement.Text;
                myList.Add(elementText);
            }
            return myList;
        }
    }
}

