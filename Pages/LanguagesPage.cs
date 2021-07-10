using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SpecFlowProject1.Hooks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SpecFlowProject1.Pages
{
    internal class LanguagesPage
    {
        internal void LanguagesPageSteps(IWebDriver driver)
        {
            // create record in languages

            // click on add new 
            IWebElement AddNew = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[3]/div[1]"));
            AddNew.Click();

            // Add Language
            IWebElement AddLanguage = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/input[1]"));
            AddLanguage.SendKeys("English");

            // Identify Language Level Button and click on it
            IWebElement LanguageLevel = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[2]/select[1]"));
            LanguageLevel.Click();

            // choose Coversational from Drop Down List
            SelectElement Conversational = new SelectElement (driver.FindElement(By.Name("level")));
            Conversational.SelectByText("Conversational");

            // click on add button
            IWebElement AddButton = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[3]/input[1]"));
            AddButton.Click();
            Thread.Sleep(5000);

            // Validate if record is Added
            Assert.That(driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]")).Text, Is.EqualTo("English"));
        }


        internal void LanguagePageSteps(IWebDriver driver)
        {

            // edit language records
            Wait.ElementPresent(driver, "XPath", "/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[last()]/tr[1]/td[3]/span[1]/i[1]");
            
            // identify last record and click on edit icon 
            IWebElement EditIcon = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[last()]/tr[1]/td[3]/span[1]/i[1]"));
            EditIcon.Click();
            Wait.ElementPresent(driver, "XPath", "/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/div[1]/div[1]/input[1]");

            // clearing old language data entered
            IWebElement ClearLanguage = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/div[1]/div[1]/input[1]"));
            ClearLanguage.Clear();
            Wait.ElementPresent(driver, "XPath", "/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/div[1]/div[1]/input[1]");

            // edit language
            IWebElement EditLanguage = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/div[1]/div[1]/input[1]"));
            EditLanguage.SendKeys("French"); 
            
            // identify Language level button and click on it
            IWebElement EditLanguageLevel = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/div[1]/div[2]/select[1]"));
            EditLanguageLevel.Click();

            // choose Basic from drop down list
            SelectElement Basic = new SelectElement (driver.FindElement(By.Name("level")));
            Basic.SelectByText("Basic");

            // click on Update
            IWebElement UpdateLanguage = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/div[1]/span[1]/input[1]"));
            UpdateLanguage.Click();
            Thread.Sleep(5000);
            
            // Validate if the record is updated
            Assert.That(driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]")).Text, Is.EqualTo("French"));
        }

        internal void LanguagesPageStep(IWebDriver driver)
        {
            // delete the record from language
            Wait.ElementPresent(driver, "XPath", "//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[last()]/tr[1]/td[3]/span[2]/i[1]");

            // identify the last record and click on remove icon 
            IWebElement DeleteLanguage = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[last()]/tr[1]/td[3]/span[2]/i[1]"));
            DeleteLanguage.Click();
            
            // Validate if the record is deleted
            //Assert.That(driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]")).Text, Is.EqualTo("French"));
        }
    }
}
