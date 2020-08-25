using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;

namespace Helpers
{
    public class BaseTestFirefoxClass
    {
        public RemoteWebDriver Driver
        {
            get;
            set;
        }

        [SetUp]
        public void TestInitialize()
        {
            var path = "/users/viktorburlaka/RiderProjects/WebDriver";
            Driver = new FirefoxDriver(path);
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