using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowProject1.Pages
{
    class HomePage
    {
        internal void HomePageSteps(IWebDriver driver)
        {
            // navigate to Languages page
            IWebElement Language = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[1]/a[1]"));
            Language.Click();   
        }

        internal void HomePagesSteps(IWebDriver driver)
        {
            // navigate to Skills Page
            IWebElement Skills = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[1]/a[2]"));
            Skills.Click();
        }

        internal void HomePageStep(IWebDriver driver)
        {
            // navigate to Education page
            IWebElement Education = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[1]/a[3]"));
            Education.Click();
            //*[@id="account-profile-section"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]
        }
    }
}
