using System;
using System.Threading;
using Helpers;
using NUnit.Framework;

namespace SeleniumTests
{
    [TestFixture]
    public class Tests : BaseTestChromeClass
    {
        [Test]
        public void Test1()
        {
            Thread.Sleep(1000);
            Driver.Navigate().GoToUrl("https://www.rabota.ua");
            
        }
    }
}