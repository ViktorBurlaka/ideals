using Helpers;
using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumTests
{
    [TestFixture]
    public class LogInSuccesFF : BaseTestFirefoxClass
    {
        [Test]
        public void LogInSuccesFFTest()
        {
            LogIn.LogInToSite(Driver, "arnoldovich1910@i.ua", "arnoldovich1910");
            Assert.IsTrue(Driver.HasElement(By.CssSelector("a[title='Orders']")));
            Assert.IsTrue(Driver.HasElement(By.CssSelector("a[title='My wishlists']")));
            Assert.IsTrue(Driver.Url.Contains(Urls.HomePage + "?controller=my-account"));
            Assert.IsTrue(Driver.PageSource.Contains("Welcome to your account."));
        }

    }
}