using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace UserInterfaceTests
{
    [TestClass]
    class AssemblyFile
    {
        public static IWebDriver driver;

        [AssemblyInitialize]
        public static void MyAssemblyInitialize(TestContext context)
        {
            //start a new chrome instance
            driver = new ChromeDriver(Extensions.LocalChromeDriverLocation);

            //implicit wait so the pages have time to load
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Extensions.LongWaitTime);
        }

        [AssemblyCleanup]
        public static void MyAssemblyCleanup()
        {
            //close the browser
            driver.Close();
        }
    }
}
