using System;
using System.Collections.Generic;
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

namespace UserInterfaceTests.Views.Skills
{
    [TestClass]
    public class CookingTests
    {
        //these two string are used to match these tests to this 
        //  controller/action pair
        public static string _controller = Extensions.SkillsControllerName;
        public static string _action = Extensions.SkillName_Cooking;


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
        public void Skills_Cooking_ClickAllLinks_NoLogin()
        {
            //Fishing links

            Extensions.ValidateClickByID(AssemblyFile.driver, "FishingLinkSkillsCooking_1", Extensions.SkillsControllerName, Extensions.SkillName_Fishing, Extensions.SkillsControllerName, Extensions.SkillName_Cooking);

            Extensions.ValidateClickByID(AssemblyFile.driver, "FishingLinkSkillsCooking_2", Extensions.SkillsControllerName, Extensions.SkillName_Fishing, Extensions.SkillsControllerName, Extensions.SkillName_Cooking);

            Extensions.ValidateClickByID(AssemblyFile.driver, "FishingLinkSkillsCooking_3", Extensions.SkillsControllerName, Extensions.SkillName_Fishing, Extensions.SkillsControllerName, Extensions.SkillName_Cooking);

            Extensions.ValidateClickByID(AssemblyFile.driver, "FishingLinkSkillsCooking_4", Extensions.SkillsControllerName, Extensions.SkillName_Fishing, Extensions.SkillsControllerName, Extensions.SkillName_Cooking);

            Extensions.ValidateClickByID(AssemblyFile.driver, "FishingLinkSkillsCooking_5", Extensions.SkillsControllerName, Extensions.SkillName_Fishing, Extensions.SkillsControllerName, Extensions.SkillName_Cooking);

            Extensions.ValidateClickByID(AssemblyFile.driver, "FishingLinkSkillsCooking_6", Extensions.SkillsControllerName, Extensions.SkillName_Fishing, Extensions.SkillsControllerName, Extensions.SkillName_Cooking);

            Extensions.ValidateClickByID(AssemblyFile.driver, "FishingLinkSkillsCooking_7", Extensions.SkillsControllerName, Extensions.SkillName_Fishing, Extensions.SkillsControllerName, Extensions.SkillName_Cooking);

        }
    }
}
