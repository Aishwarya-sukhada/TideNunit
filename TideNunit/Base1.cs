using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using Serilog.Core;
using Serilog;

namespace TideNunit
{
   
  
   public class Base1
    {
        public static IWebDriver driver;
        public static ExtentReports extents;
       
        public void ScreenShot1(String name)
        {
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile(@"C:\Users\mindc1may386\source\repos\TideNunit\ScreenShot1" + name+".png");
        }

        [SetUp]
        public void TestMethod1()
        {
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://tide.com/en-us");
        }
        [OneTimeSetUp]
        public void log1()
        {

            var htmlReport = new ExtentHtmlReporter(@"C:\Users\mindc1may386\source\repos\TideNunit\index1.html");
            htmlReport.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Standard;
            extents = new ExtentReports();
            extents.AttachReporter(htmlReport);
            LoggingLevelSwitch loggingLevel = new LoggingLevelSwitch(Serilog.Events.LogEventLevel.Debug);
            Log.Logger = new LoggerConfiguration().MinimumLevel.ControlledBy(levelSwitch: loggingLevel).WriteTo.File(
                @"C:\Users\mindc1may386\source\repos\TideNunit\log", outputTemplate: "{TimeSpan:yyyy-MM-dd HH:mm:ss.fff} | {Level:u3} | {Message}{NewLine}", rollingInterval: RollingInterval.Day).CreateLogger();
        }
        [OneTimeTearDown]
        public static void CloseReport()
        {
            extents.Flush();
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

    }
}
