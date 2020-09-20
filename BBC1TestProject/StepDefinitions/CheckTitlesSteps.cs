using BBC1TestProject.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace BBC1TestProject.StepDefinitions
{
    [Binding]
    public class CheckTitlesSteps
    {
        HomePage homePage = new HomePage();
        NewsPage newsPage = new NewsPage();
        SearchResultPage searchResultPage = new SearchResultPage();

        [When(@"I click on News button")]
        public void WhenIClickOnNewsButton()
        {
            homePage.ClickOnNewsBtn();
        }
        
        [When(@"I enter Category link of the headline article in Search field")]
        public void WhenIEnterCategoryLinkOfTheHeadlineArticleInSearchField()
        {
            newsPage.GetCategoryLinkText();
            newsPage.Search();

        }

        [Then(@"the title of the first article is ""(.*)""")]
        public void ThenTheTitleOfTheFirstArticleIs(string headlineText)
        {
            Assert.AreEqual(headlineText, searchResultPage.GetFirstResultArticleText()); //NUnit
        }


        [Then(@"the title of the headline article is ""(.*)""")]
        public void ThenTheTitleOfTheHeadlineArticleIs(string headlineText)
        {
            Assert.AreEqual(headlineText, newsPage.GetTextOfTitleOfMainArticle()); //NUnit
        }

        //[Then(@"secondary article titles are ""(.*)""")]
        //public void ThenSecondaryArticleTitlesAre(List<string> titles)//string title) //
        //{
        //    //List<String> mtList = new List<string>(table.Split(','));
        //    //titles.Rows.Select(row => row.Values.FirstOrDefault()).ToList();
        //    //Console.WriteLine(newsPage.secondaryArticleTitleList());
        //    //CollectionAssert.AreEquivalent(newsPage.secondaryArticleTitleList(), mtList);
        //    //Assert.IsTrue(newsPage.secondaryArticleTitleList().Contains(mtList)); //NUnit
        //    //ScenarioContext.Current.Get<List<string>>("titles").Contains(newsPage.secondaryArticleTitleList().ToString());
        //    Assert.AreEqual(titles, newsPage.GetSecondaryArticleTitleList());
           
        //}

        //[Then(@"secondary article titles = ""(.*)""")]
        //public void ThenSecondaryArticleTitles(string titles, Table table)
        //{
        //    //Assert.AreEqual( titles.Split().ToArray(), newsPage.GetSecondaryArticleTitleList().ToArray());
        //    //Assert.AreEqual(table.Rows.Select(s => s[0]).ToList(), newsPage.GetSecondaryArticleTitleList());
        //    //Assert.IsTrue(newsPage.GetSecondaryArticleTitleList().SequenceEqual(titles.Split().ToList()));
        //    Assert.IsTrue(newsPage.GetSecondaryArticleTitleList().Contains(titles));

        //}

        //[Then(@"Secondary article titles are:")]
        //public void ThenSecondaryArticleTitlesAre(Table table)
        //{
        //    Assert.AreEqual(newsPage.GetSecondaryArticleTitleList(), table.Rows.Select(s => s[0]).ToList());

        //}

        [Then(@"Then Secondary article titles are: ""(.*)""")]
        public void ThenSAAre(string titles)
        {
            Assert.IsTrue(newsPage.GetSecondaryArticleTitleList().Contains(titles));
        }



    }
}
