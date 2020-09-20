using BBC1TestProject.PageObjects;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Analytics;


namespace BBC1TestProject.Features
{
    [Binding]
    public class SubmitAQuestionSteps
    {
        HomePage homePage = new HomePage();
        NewsPage newsPage = new NewsPage();
        CoronavirusPage coronavirusPage = new CoronavirusPage();
        HaveYourSayPage haveYourSayPage = new HaveYourSayPage();
        ShareYourStoryPage shareYourStoryPage = new ShareYourStoryPage();

        [Given(@"I navigate to the website")]

        public void GivenINavigateToTheWebsite()
        {
            homePage.NavigateToWebsite();
        }

        //[When(@"I click on News button")]
        //public void WhenIClickOnNewsButton()
        //{
        //    ScenarioContext.Current.Pending();
        //}

        //[When(@"I click on Coronavirus button")]
        //public void WhenIClickOnCoronavirusButton()
        //{
        //    ScenarioContext.Current.Pending();
        //}

        //[When(@"I click on Your Coronavirus Stories button")]
        //public void WhenIClickOnYourCoronavirusStoriesButton()
        //{
        //    ScenarioContext.Current.Pending();
        //}

        [Given(@"I click on News button")]
        public void GivenIClickOnNewsButton()
        {
            homePage.ClickOnNewsBtn();
        }

        [Given(@"I click on Coronavirus button")]
        public void GivenIClickOnCoronavirusButton()
        {
            newsPage.ClickOnMaybeLaterBtnBtn();
            newsPage.ClickOnCoronavirusBtn();
        
        }

        [Given(@"I click on Your Coronavirus Stories button")]
        public void GivenIClickOnYourCoronavirusStoriesButton()
        {
            coronavirusPage.ClickOnYourCoronavirusStoryBtn();
        }


        [When(@"I click on How to share with BBC News")]
        public void WhenIClickOnHowToShareWithBBCNews()
        {
            haveYourSayPage.ClickOnHowToShareBtn();
        }

        [When(@"I enter the Story Text ""(.*)""")]
        public void WhenIEnterTheStoryText(string sometext)
        {
            shareYourStoryPage.EnterSomeTextToStoryField(sometext);
        }

        [When(@"I enter the Name ""(.*)""")]
        public void WhenIEnterTheName(string name)
        {
            shareYourStoryPage.EnterSomeTextToStoryField(name);
        }


        //[When(@"I enter the Story Text")]
        //public void WhenIEnterTheStoryText()
        //{
        //    ScenarioContext.Current.Pending();
        //}

        //[When(@"I enter the Name")]
        //public void WhenIEnterTheName()
        //{
        //    ScenarioContext.Current.Pending();
        //}

        //[When(@"I pick I am over (.*) years old checkbox")]
        //public void WhenIPickIAmOverYearsOldCheckbox()
        //{
        //    shareYourStoryPage.AdmitIAmOver16Checkbox();
        //}

        [When(@"I pick I am over sixteen years old")]
        public void WhenIPickIAmOverSixteenYearsOld()
        {
            shareYourStoryPage.AdmitIAmOver16Checkbox();
        }


        [When(@"I pick I accept the Terms of Service checkbox")]
        public void WhenIPickIAcceptTheTermsOfServiceCheckbox()
        {
            shareYourStoryPage.AdmitIAcceptCheckbox();
        }
        
        [When(@"I click the Submit button")]
        public void WhenIClickTheSubmitButton()
        {
            shareYourStoryPage.ClickOnSubmitBtn();
        }

        //[Then(@"I should stay on the same page \(https://www\.bbc\.com/news/(.*)\)")]
        ///// public void ThenIShouldStayOnTheSamePageHttpsWww_Bbc_ComNews(int p0)
        //public void ThenIShouldStayOnTheSamePageHttpsWww_Bbc_ComNews(string url)
        //{
        //}

        [Then(@"I should stay on the same page with URL ""(.*)""")]
        public void ThenIShouldStayOnTheSamePageWithURL(string url)
        {
            Assert.AreEqual(url, shareYourStoryPage.GetPageURL); //NUnit

            url.Should().Be(shareYourStoryPage.GetPageURL); //FluentAssertion
        }

    }
}
