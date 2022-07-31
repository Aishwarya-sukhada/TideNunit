using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Linq;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using Serilog;
using OpenQA.Selenium.Interactions;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Model;

namespace TideNunit
{
    [TestFixture]
   public class TestCase:Base1


    {
        Base1 ss = new Base1();

        [Test]
        public void SignUp_valid()
        {
            //Valid sign Up
            ExtentTest t1 = extents.CreateTest("SignUp_valid").Info("Valid signup has started");
            driver.Navigate().GoToUrl("https://www.pggoodeveryday.com/signup/tide-coupons/");
            Serilog.Log.Information("Opens the page of signUp");
            t1.Info("Opens the sign Up page");

            driver.FindElement(By.XPath("//input[@id='name']")).SendKeys("Aishwarya");
            Thread.Sleep(3000);
            Serilog.Log.Information("Enters the first name");
            t1.Info("Enters the first name");

            driver.FindElement(By.XPath("//input[@id='email']")).SendKeys("aishu9599@gmail.com");
            Thread.Sleep(3000);
            Serilog.Log.Information("Enters the mail id");
            t1.Info("Enters the mail id");

            driver.FindElement(By.XPath("//input[@id='password']")).SendKeys("TajMahal@123");
            Thread.Sleep(3000);
            Serilog.Log.Information("Enters the password");
            t1.Info("Enters the password");

            driver.FindElement(By.XPath("//input[@value='CREATE ACCOUNT']")).Click();
            Serilog.Log.Information("Clicks to create account");
            t1.Info("Clicks to create account");
            ss.ScreenShot1("Valid Signup");

        }
        [Test]
        public void SignUp_pwd_invalid()
        {
            ExtentTest t2 = extents.CreateTest("SignUp_pwd_invalid").Info(" signup has started");
            driver.Navigate().GoToUrl("https://www.pggoodeveryday.com/signup/tide-coupons/");
            Serilog.Log.Information("Opens the page of signUp");
            t2.Info("Opens the sign Up page");


            driver.FindElement(By.XPath("//input[@id='name']")).SendKeys("Aishwarya");
            Thread.Sleep(3000);
            Serilog.Log.Information("Enters the first name");
            t2.Info("Enters the first name");

            driver.FindElement(By.XPath("//input[@id='email']")).SendKeys("aishu9599@gmail.com");
            Thread.Sleep(3000);
            Serilog.Log.Information("Enters the mail id");
            t2.Info("Enters the mail id");

            driver.FindElement(By.XPath("//input[@id='password']")).SendKeys("@123");
            Thread.Sleep(3000);
            Serilog.Log.Information("Enters the invalid password");
            t2.Info("Enters the invalid password");

            driver.FindElement(By.XPath("//input[@value='CREATE ACCOUNT']")).Click();
            Serilog.Log.Information("Clicks to create account");
            t2.Info("Clicks to create account");
            ss.ScreenShot1("inValid pwd Signup");


        }
        [Test]
        public void SignUp_mail_invalid()
        {
            ExtentTest t3 = extents.CreateTest("SignUp_mail_invalid").Info("signup has started");
            driver.Navigate().GoToUrl("https://www.pggoodeveryday.com/signup/tide-coupons/");
            Serilog.Log.Information("Opens the page of signUp");
            t3.Info("Opens the sign Up page");

            driver.FindElement(By.XPath("//input[@id='name']")).SendKeys("Aishwarya");
            Thread.Sleep(3000);
            Serilog.Log.Information("Enters the first name");
            t3.Info("Enters the first name");

            driver.FindElement(By.XPath("//input[@id='email']")).SendKeys("aishu9599.com");
            Thread.Sleep(3000);
            Serilog.Log.Information("Enters the invalid mail id");
            t3.Info("Enters the invalid mail id");

            driver.FindElement(By.XPath("//input[@id='password']")).SendKeys("TajMahal@123");
            Thread.Sleep(3000);
            Serilog.Log.Information("Enters the password");
            t3.Info("Enters the password");

            driver.FindElement(By.XPath("//input[@value='CREATE ACCOUNT']")).Click();
            Serilog.Log.Information("Clicks to create account");
            t3.Info("Clicks to create account");
            ss.ScreenShot1("InValid mail Signup");


        }

        [Test]
        public void Login_Valid()
        {
            ExtentTest t4 = extents.CreateTest("Login_valid").Info("Login has started");
            driver.Navigate().GoToUrl(" https://www.pggoodeveryday.com/login/");
            Serilog.Log.Information("Opens the page of signUp");
            t4.Info("Opens the sign Up page");

            driver.FindElement(By.XPath("//input[@id='login-email']")).SendKeys("aishu9599@gmail.com");
            Thread.Sleep(3000);
            Serilog.Log.Information("Enters the valid mailID");
            t4.Info("Enters the valid mailID");

            driver.FindElement(By.XPath("//input[@id='login-password']")).SendKeys("TajMahal@123");
            Thread.Sleep(3000);
            Serilog.Log.Information("Enters the password");
            t4.Info("Enters the password");

            driver.FindElement(By.XPath("//input[@value='LOG IN']")).Click();
            Thread.Sleep(4000);
            Serilog.Log.Information("Logins to account");
            t4.Info("Logins to account");

            ss.ScreenShot1("Valid Login");

        }
        [Test]
        public void Login_Invalid()
        {
            ExtentTest t5 = extents.CreateTest("login_Invalid").Info("login has started");
            driver.Navigate().GoToUrl(" https://www.pggoodeveryday.com/login/");
            Serilog.Log.Information("Opens the page of login");
            t5.Info("Opens the page to login");

            driver.FindElement(By.XPath("//input[@id='login-email']")).SendKeys("aishu9599.com");
            Thread.Sleep(3000);
            Serilog.Log.Information("Enters the invalid mail id");
            t5.Info("Enters the invalid mailID");

            driver.FindElement(By.XPath("//input[@id='login-password']")).SendKeys("@123");
            Thread.Sleep(3000);
            Serilog.Log.Information("Enters the password");
            t5.Info("Enters the password");

            driver.FindElement(By.XPath("//input[@value='LOG IN']")).Click();
            Serilog.Log.Information("Login to account");
            t5.Info("Login to account");
            ss.ScreenShot1("InValid Login");


        }
        [Test]
        public void Search_Detergent()
        {
            ExtentTest t6 = extents.CreateTest("Search_Detergent").Info("searching the product");
            Thread.Sleep(8000);
            driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            Serilog.Log.Information("Clicks to close the pop-up");
            t6.Info("Clicks to close the pop-up");


            driver.FindElement(By.XPath("//input[@name='q']")).SendKeys("Detergent");
            Thread.Sleep(4000);
            Serilog.Log.Information("Enters the product name detergent");
            t6.Info("Enters the product name detergent");


            driver.FindElement(By.XPath("//*[@aria-label='Sumbit Search']")).Click();
            Thread.Sleep(5000);
            Serilog.Log.Information("Clicks on search button");
            t6.Info("Clicks on search button");
            ss.ScreenShot1("Search Detergents");


        }
        [Test]
        public void Search_invalid()
        {
            ExtentTest t7 = extents.CreateTest("Search_Invalid").Info("Searching with invalid data");
            Thread.Sleep(8000);
            driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            Serilog.Log.Information("Clicks to close the pop-up");
            t7.Info("Clicks to close the pop-up");

            driver.FindElement(By.XPath("//input[@name='q']")).SendKeys("furniture");
            Thread.Sleep(4000);
            Serilog.Log.Information("Enters the invalid data");
            t7.Info("Enters the invalid data");

            driver.FindElement(By.XPath("//*[@aria-label='Sumbit Search']")).Click();
            Thread.Sleep(5000);
            Serilog.Log.Information("Clicks on search button");
            t7.Info("Clicks on search button");

            ss.ScreenShot1("Search invalid data");
        }
        [Test]
        public void Coupons()
        {
            ExtentTest t8 = extents.CreateTest("Coupons and Rewards").Info("looking on coupond and rewards");
            Thread.Sleep(8000);
            driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            Serilog.Log.Information("Clicks to close the pop-up");
            t8.Info("Clicks to close the pop-up");


            driver.FindElement(By.XPath("//a[normalize-space()='Coupons and Rewards']")).Click();
            Thread.Sleep(5000);
            Serilog.Log.Information("Clicks on coupon and rewards");
            t8.Info("Clicks on coupon and rewards");
            ss.ScreenShot1("Coupons and rewards");
        }
        [Test]
        public void Hover_ShopProducts()
        {
            ExtentTest t9 = extents.CreateTest(" Hover_ShopProducts").Info("looking into shop products");
            Thread.Sleep(8000);
            driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            Serilog.Log.Information("Clicks to close the pop-up");
            t9.Info("Clicks to close the pop-up");

            IWebElement e = driver.FindElement(By.XPath("//a[@data-action-detail='Shop Products']"));
           
            Actions acc = new Actions(driver);
            acc.MoveToElement(e).Perform();
            Thread.Sleep(4000);
            Serilog.Log.Information("Look for shop products");
            t9.Info("Look for shop products");


            ss.ScreenShot1("Hover ShopProduct");
        }


        [Test]
        public void Hover_commitements()
        {
            ExtentTest t10 = extents.CreateTest("Hover_commitements").Info("looking into commitements");
            Thread.Sleep(8000);
            driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            Serilog.Log.Information("Clicks to close the pop-up");
            t10.Info("Clicks to close the pop-up");

            IWebElement e = driver.FindElement(By.XPath("//a[@data-action-detail='Our Commitment']"));
            Actions acc = new Actions(driver);
            acc.MoveToElement(e).Perform();
            Thread.Sleep(4000);
            Serilog.Log.Information("Displays then commitement");
            t10.Info("Displays then commitement");

            ss.ScreenShot1("Hover on comitements");


        }


    }
}
