using NUnit.Framework;
using SpecFlowProject1.Hooks;
using SpecFlowProject1.Pages;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinition
{
    [Binding]
    class EducationPageSteps : Common_Driver
    {
        
        [Given(@"I'd like to logged in profile page")]
        public void GivenIDLikeToLoggedInProfilePage()
        {
            // page object for Login page
            LoginPage LoginObj = new LoginPage();
            LoginObj.LoginPageSteps(driver);
        }
       
        [Given(@"I navigate to Education Page")]
        public void GivenINavigateToEducationPage()
        {
            // page object for home page
            HomePage HomeObj = new HomePage();
            HomeObj.HomePageStep(driver);
        }
        
        [Then(@"I should be able to create Education record with valid details")]
        public void ThenIShouldBeAbleToCreateEducationRecordWithValidDetails()
        {
            // Education Page Obj and Steps
            EducationPage EducationObj = new EducationPage();
            EducationObj.EducationPageSteps(driver);
        }
        
        [Then(@"I should be able to edit Education record")]
        public void ThenIShouldBeAbleToEditEducationRecord()
        {
            // page object for edit Education page
            EducationPage EducationEditObj = new EducationPage();
            EducationEditObj.EducationsPageSteps(driver);
        }
        
        [Then(@"I should be able to Delete Education record")]
        public void ThenIShouldBeAbleToDeleteEducationRecord()
        {
            // page object for delete Education page
            EducationPage EducationDeleteObj = new EducationPage();
            EducationDeleteObj.EducationPagesSteps(driver);
        }

        // Quit driver
        public void FinalSteps()
        {
            driver.Quit();
        }
    }
}
