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

namespace UserInterfaceTests.Views.Error
{
    [TestClass]
    public class Page404Tests
    {
        //these two string are used to match these tests to this 
        //  controller/action pair
        public static string _controller = "Error";
        public static string _action = "Page404";

        [ClassInitialize]
        public static void MyClassInitialize(TestContext context)
        {
            //start by naviagating to the controller/action view page
            Extensions.NavigateToPage(AssemblyFile.driver, _controller, _action);

            //now check that navbar works
            Views.Shared.Layout.NavBar_ClickAllLinks(AssemblyFile.driver, _controller, _action);

            //now check that footer works
            Views.Shared.Layout.Footer_ClickAllLinks(AssemblyFile.driver, _controller, _action);
        }

        [TestInitialize]
        public void MyTestInitialize()
        {
            //start every test by naviagating to the controller/action view 
            //  page
            Extensions.NavigateToPage(AssemblyFile.driver, _controller, _action);
        }

        [TestMethod]
        public void Error_Page404_ClickAllLinks_NoLogin()
        {
            Assert.AreEqual(true, true);//replace this with links if any become available on page
        }

        //a test for getting to the page by bad url AKA 404 error
        // This is essentially just plugging in a bad name to make sure my page displays
        // and not the default 404 page
        [TestMethod]
        public void Error_Page404_DisplaysAfter404()
        {
            //navigate to bad page
            AssemblyFile.driver.Navigate().GoToUrl(Extensions.BaseUrl + "/aslkdfdslkfn");

            //check that the page is my 404 page
            var PageResult = AssemblyFile.driver.FindElement(By.Id("Page-Done"));
            var AreaResult = AssemblyFile.driver.FindElement(By.Id("Area--Done"));
            var ControllerResult = AssemblyFile.driver.FindElement(By.Id("Controller-" + _controller + "-Done"));
            var ViewResult = AssemblyFile.driver.FindElement(By.Id("View-" + _action + "-Done"));
        }
    }
}
