using System;
using System.IO;
using System.Reflection;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace Helpers
{
    public class BaseTestChromeClass
    {
        public RemoteWebDriver Driver
        {
            get;
            set;
        } 
        
        [SetUp]
        public void TestInitialize()
        {
            //var path = "/users/viktorburlaka/RiderProjects/WebDriver";
            var path = "chromedriver.exe";
            Driver = new ChromeDriver(path);
            Driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TestClenup()
        {
            if (Driver != null)
            {
                Driver.Quit();
            }
        }
    }
}