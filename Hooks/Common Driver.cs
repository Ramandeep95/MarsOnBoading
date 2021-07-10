using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowProject1.Hooks
{
    class Common_Driver
    {
        // Initiate and launch WebDriver
        public static IWebDriver driver = new ChromeDriver(@"E:\Projects\SpecflowProject1\SpecFlowProject1");
    }
}
