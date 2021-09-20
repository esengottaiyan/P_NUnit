using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using P_NUnit.Helper;
using P_NUnit.PageElements;

namespace P_NUnit
{
    public class Tests
    {
        #region "Variable Declaration and Initialization"

        Drivers drivers = new Drivers();
        IWebDriver driver;
        #endregion

        #region "Test Case"
        [Test]
        public void TaskmeterLogin()
        {
            string Url = "http://taskmeter.techaffinity.us/";

            drivers.GotoUrl(Url);

            Thread.Sleep(3000);

            driver = drivers.InheritDriver;

            //Enter Username and Password
            driver.FindElement(Elements.L_UserName).SendKeys("elangos@techaffinity.com");
            driver.FindElement(Elements.L_Password).SendKeys("$Esme123");

            //Submit the credentials

            driver.FindElement(Elements.L_Submit).Click();

            drivers.CloseDriver();

            Assert.True(true ,"Having Error");
        }
        #endregion
    }
}