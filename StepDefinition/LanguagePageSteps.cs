using NUnit.Framework;
using SpecFlowProject1.Hooks;
using SpecFlowProject1.Pages;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinition
{
    [Binding]
    class LanguagePageSteps : Common_Driver
    {
        
        [Given(@"I have log in profile page")]
        public void GivenIHaveLogInProfilePage()
        {
            // page object for Login page
            LoginPage LoginObj = new LoginPage();
            LoginObj.LoginPageSteps(driver);
        }
        
        [Given(@"I navigate to Language Page")]
        public void GivenINavigateToLanguagePage()
        {
            // page object for home page
            HomePage HomeObj = new HomePage();
            HomeObj.HomePageSteps(driver);
        }
        
        [Then(@"I should be able to create Languages record with valid details")]
        public void ThenIShouldBeAbleToCreateLanguagesRecordWithValidDetails()
        {
            // page object for Languages page
            LanguagesPage LanguageObj = new LanguagesPage();
            LanguageObj.LanguagesPageSteps(driver);
        }
        
        [Then(@"I should be able to edit Languages record with valid details")]
        public void ThenIShouldBeAbleToEditLanguagesRecordWithValidDetails()
        {
            // page object for edit language page
            LanguagesPage LanguageEditObj = new LanguagesPage();
            LanguageEditObj.LanguagePageSteps(driver);
            }
        
        [Then(@"I should be able to delete Languages record with valid details")]
        public void ThenIShouldBeAbleToDeleteLanguagesRecordWithValidDetails()
        {
            // page object for delete language record
            LanguagesPage LanguageDeleteObj = new LanguagesPage();
            LanguageDeleteObj.LanguagesPageStep(driver);
        }

        // Quit driver
        public void FinalSteps()
        {
            driver.Quit();
        }
    }
}
