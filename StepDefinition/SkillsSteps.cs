using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowProject1.Hooks;
using SpecFlowProject1.Pages;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinition
{
    [Binding]
    class SkillsSteps : Common_Driver
    {
        
        [Given(@"I'd  log in profile page")]
        public void GivenIDLogInProfilePage()
        {
        // define Driver
        // public static IWebDriver driver = new ChromeDriver(@"F:\SpecflowProject1\SpecFlowProject1\SpecFlowProject1");

        // page object for Login page
        LoginPage LoginObj = new LoginPage();
            LoginObj.LoginPageSteps(driver);
        }
        
        [Given(@"I navigate to Skills Page")]
        public void GivenINavigateToSkillsPage()
        {
            // page object for home page
            HomePage HomeObj = new HomePage();
            HomeObj.HomePagesSteps(driver);
        }
       
        [Then(@"I should be able to create Skills record with valid details")]
        public void ThenIShouldBeAbleToCreateSkillsRecordWithValidDetails()
        {
            // Page object for Skills Page 
            SkillsPage SkillsObj = new SkillsPage();
            SkillsObj.SkillsPageSteps(driver);
        }
        
        [Then(@"I should be able to edit Skills record")]
        public void ThenIShouldBeAbleToEditSkillsRecord()
        {
            // Page object for edit skills page 
            SkillsPage EditSkillsObj = new SkillsPage();
            EditSkillsObj.SkillPageSteps(driver);
        }
        
        [Then(@"I should be able to Delete Skills record")]
        public void ThenIShouldBeAbleToDeleteSkillsRecord()
        {
            // page object to delete skills record
            SkillsPage DeleteSkillsObj = new SkillsPage();
            DeleteSkillsObj.SkillPageStep(driver);
        }

        // Quit driver
        public void FinalSteps()
        {
            driver.Quit();
        }
    }
}
