using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace P_NUnit.Helper
{
    /// <summary>
    /// As Default - Chrome webdrive has enabled. we can choose Firebox and Edge
    /// </summary>
    class Drivers
    {
        #region "Variable Declaration and Initialization"
        IWebDriver webDriver;
        #endregion

        #region "Constructor"
        public Drivers()
        {
            //Chrome Browser
            ChromeOptions ChromeOptions = new ChromeOptions();
            ChromeOptions.AcceptInsecureCertificates = true;//only if it is secure site

            ////FireFox Browser
            //FirefoxOptions FirefoxOptions = new FirefoxOptions();
            //FirefoxOptions.AcceptInsecureCertificates = true;//only if it is secure site

            ////Microsoft Edge Browser
            //EdgeOptions EdgeOptions = new EdgeOptions();
            //EdgeOptions.AcceptInsecureCertificates = true;//only if it is secure site

            webDriver = new ChromeDriver(ChromeOptions);
            webDriver.Manage().Window.Maximize();
        }
        #endregion

        #region "Default Methods"
        /// <summary>
        /// Set Url for webdriver
        /// </summary>
        /// <param name="url"></param>
        public void GotoUrl(string url)
        {
            webDriver.Url = url;
        }
        /// <summary>
        /// Close the webdrivers
        /// </summary>
        public void CloseDriver()
        {
            webDriver.Quit();
        }
        /// <summary>
        /// Property - should return current drivers
        /// </summary>
        public IWebDriver InheritDriver
        {
            get { return webDriver; }
        }
        #endregion
    }
}
