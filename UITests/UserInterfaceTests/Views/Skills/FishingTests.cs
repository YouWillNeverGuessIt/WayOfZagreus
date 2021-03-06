﻿using System;
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
    public class FishingTests
    {
        //these two string are used to match these tests to this 
        //  controller/action pair
        public static string _controller = Extensions.SkillsControllerName;
        public static string _action = Extensions.SkillName_Fishing;


        [ClassInitialize]
        public static void MyClassInitialize(TestContext context)
        {
            //start by naviagating to the controller/action view page
            Extensions.NavigateToPage(AssemblyFile.driver, _controller, _action);

            //now check that navbar works
            Views.Shared.Layout.NavBar_ClickAllLinks(AssemblyFile.driver, _controller, _action);

            //now check that footer works
            Views.Shared.Layout.Footer_ClickAllLinks(AssemblyFile.driver, _controller, _action);

            //since this is a skills page, check that skills layout is working
            Views.Skills._SkillsLayout.SideBar_ClickAllLinks(AssemblyFile.driver, _controller, _action);
        }

        [TestInitialize]
        public void MyTestInitialize()
        {
            //start every test by naviagating to the controller/action view 
            //  page
            Extensions.NavigateToPage(AssemblyFile.driver, _controller, _action);
        }


        [TestMethod]
        public void Skills_Fishing_ClickAllLinks_NoLogin()
        {
            //combat links

            Extensions.ValidateClickByID(AssemblyFile.driver, "CombatLinkSkillsFishing_1", Extensions.SkillsControllerName, Extensions.SkillName_CombatSkills, _controller, _action);

            //cooking links

            Extensions.ValidateClickByID(AssemblyFile.driver, "CookingLinkSkillsFishing_1", Extensions.SkillsControllerName, Extensions.SkillName_Cooking, _controller, _action);

            //Smithing links

            Extensions.ValidateClickByID(AssemblyFile.driver, "SmithingLinkSkillsFishing_1", Extensions.SkillsControllerName, Extensions.SkillName_Smithing, _controller, _action);
            Extensions.ValidateClickByID(AssemblyFile.driver, "SmithingLinkSkillsFishing_2", Extensions.SkillsControllerName, Extensions.SkillName_Smithing, _controller, _action);


            //off site links
            //check that the google sheets link works
            AssemblyFile.driver.FindElement(By.Id("GoogleSheetsosrsSheetLink")).Click();
            //manually validate link to google sheets worked because it is an 
            //  off -site link. I do this by looking for the id 
            //  "docs-title-widget". This is a div object attached to the title
            //  of the sheet you are view. So hopefully that will not display 
            //  if you are not view a sheet. this might need some work to truly
            //  verify that the link has taken the user to the right place.
            //Should open in new tab
            var browserTabs = AssemblyFile.driver.WindowHandles;
            AssemblyFile.driver.SwitchTo().Window(browserTabs[1]);
            AssemblyFile.driver.FindElement(By.Id(Extensions.GoogleSheetsOSRSSheet_ID));
            //close the new tab
            AssemblyFile.driver.Close();
            //return to original tab
            AssemblyFile.driver.SwitchTo().Window(browserTabs[0]);

        }
    }
}
