using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Security.Permissions;
using System.Net.NetworkInformation;
using System.Security.AccessControl;
using System.Web;
using OpenQA.Selenium.Interactions;

namespace ClassLibrary1
{
    public class OtherCases
    {

        [SetUp]
        public static void SETUP()
        {
            driver = new ChromeDriver(driverPath);
            driver.Manage().Window.Maximize();
            driver.Url = "https://fera.lt/";
            driver.Manage().TimeOuts().ImplicitWait = TimeSpan.FromSeconds(30);

        }

        [TearDown]
        public static void TearDown()
        {
            //driver.Quit();
        }
    }

}
