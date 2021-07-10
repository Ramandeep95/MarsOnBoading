using NUnit.Framework;
using SpecFlowProject1.Hooks;
using SpecFlowProject1.Pages;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinition
{
    [Binding]
    class CertificationsPageSteps : Common_Driver
    {
        
        [Given(@"I logged in profile page")]
        public void GivenILoggedInProfilePage()
        {
            // page object for Login page
            LoginPage LoginObj = new LoginPage();
            LoginObj.LoginPageSteps(driver);
        }
       
        [Given(@"I navigate to Certification Page")]
        public void GivenINavigateToCertificationPage()
        {
            // page object for home page
            HomePage HomeObj = new HomePage();
            HomeObj.HomePageSteps(driver);
        }

        [Then(@"I should be able to create Certification record with valid details")]
        public void ThenIShouldBeAbleToCreateCertificationRecordWithValidDetails()
        {
            // page object for Cetification Page 
            CertificationsPage CertificationObj = new CertificationsPage();
            CertificationObj.CertificationPageSteps(driver);
        }

        // Quit driver
        public void FinalSteps()
        {
            driver.Quit();
        }
    }
}
