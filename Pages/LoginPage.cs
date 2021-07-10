using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowProject1.Hooks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SpecFlowProject1.Pages
{
    class LoginPage 
    {
        internal void LoginPageSteps(IWebDriver driver)
        {
            // launch the profile page portal
            driver.Navigate().GoToUrl("http://localhost:5000");
            driver.Manage().Window.Maximize();
            Thread.Sleep(5000);
            try
            {
               
                // identify signIn Button and click on it
                IWebElement SignIn = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/a[1]"));
                SignIn.Click();
                Thread.Sleep(2000);

                driver.SwitchTo().ActiveElement();

                // populate login page test data collection
                ExcelLibHelpers.PopulateInDataCollection(@"E:\Projects\SpecflowProject1\SpecFlowProject1\SpecFlowProject1\TestData\MarsLogo.xlsx");
                Wait.ElementPresent(driver, "Name", "email");

                // identify Email Address textbox and enter Email address
                IWebElement EmailAddress = driver.FindElement(By.Name("email"));
                EmailAddress.SendKeys(ExcelLibHelpers.ReadData(2, "Email address"));
                Wait.ElementPresent(driver, "Name", "password");

                // indentify Password textbox and enter Password
                IWebElement Password = driver.FindElement(By.Name("password"));
                Password.SendKeys(ExcelLibHelpers.ReadData(2, "Password"));
                Wait.ElementPresent(driver, "XPath", "/html[1]/body[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[4]/button[1]");               

                // identify login button and click on it
                IWebElement Login = driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[4]/button[1]"));
               Login.Click();
               Thread.Sleep(2000);

        }
            catch (Exception ex)
            {
                Assert.Fail("Test failed at login page", ex.Message);
            }

    // verify home page
     IWebElement MarsLogo = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/a[1]"));

            if (MarsLogo.Text == "Mars Logo")
            {
                Console.WriteLine("Test Passed, Logged-in Successfully");
            }
            else
            {
                Console.WriteLine("Test Failed, Login Failed");
            }


        }
    }
}
