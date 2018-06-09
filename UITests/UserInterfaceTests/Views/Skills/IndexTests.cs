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
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [TestClass]
    public class IndexTests
    {
        //these two string are used to match these tests to this 
        //  controller/action pair
        public static string _controller = Extensions.SkillsControllerName;
        public static string _action = Extensions.TheWordIndex;

        //[AssemblyInitialize]
        //public static void AssemblyInitialize(TestContext context)
        //{
        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        //}
        //should be class initialize, not assembly initialize. Assembly 
        //  initialize should be in a seperate file. This is because assembly
        //  initialize is run before ALL tests, class initialize is before all
        //  tests in a class, and test initialize is before individual tests
        //Assembly cleanup is run after ALL tests, class cleanup is run after ALL tests in ALL classes, and test cleanup is run after each test.  
        //the order of all this crap is:
        // assembly initialize
        //  class1 initialize
        //   class1 test1 initialize
        //   class1 test1 test
        //   class1 test1 cleanup
        //   class1 test2 initialize
        //   class1 test2
        //   class1 test2 cleanup
        //  class2 initialize
        //   class2 test1 initialize
        //   class2 test1
        //   class2 test1 cleanup
        //  class1 cleanup
        //  class2 cleanup
        // assembly cleanup

        //[ClassInitialize]
        //public static void MyClassInitialize(TestContext context)
        //{

        //}

        //[ClassCleanup]
        //public static void MyClassCleanup()
        //{

        //}

        [ClassInitialize]
        public static void MyClassInitialize(TestContext context)
        {
            //start by naviagating to the controller/action view page
            Extensions.NavigateToPage(AssemblyFile.driver, _controller, _action);

            //now check that navbar works
            Views.Shared.Layout.NavBar_ClickAllLinks(AssemblyFile.driver, _controller, _action);

            //now check that footer works
            Views.Shared.Layout.Footer_ClickAllLinks(AssemblyFile.driver, _controller, _action);

            //don't need side bar tests even tho this is a skills page. This already has links to other skills
        }

        [TestInitialize]
        public void MyTestInitialize()
        {
            //start every test by naviagating to the controller/action view 
            //  page
            Extensions.NavigateToPage(AssemblyFile.driver, _controller, _action);
        }


        //clicks all links on the skills index page
        [TestMethod]
        public void Skills_Index_ClickAllLinks_NoLogin()
        {
            //check that the skills map works
            Shared.Layout.SkillsMap_ClickAllLinks(AssemblyFile.driver, _controller, _action);


            //check that the link to osrs hiscores works
            AssemblyFile.driver.FindElement(By.Id(Extensions.LinkToOSRSHiscores_SkillsIndexID)).Click();      
            //manually validate link to osrs hiscores worked. I do this by 
            // looking for id "contentHiscores". I think that only shows up 
            // when you are displaying a hiscore table for a user.
            //Should open in a new tab
            var browserTabs = AssemblyFile.driver.WindowHandles;
            AssemblyFile.driver.SwitchTo().Window(browserTabs[1]);
            AssemblyFile.driver.FindElement(By.Id(Extensions.OSRSHiscoresZagreus420_ID));
            //close the new tab
            AssemblyFile.driver.Close();
            //now return to original tab
            AssemblyFile.driver.SwitchTo().Window(browserTabs[0]);

            //check that the written links to each of the skills works
            //Agility
            Extensions.ValidateClickByID(AssemblyFile.driver, "AgilityLinkSkillsIndex", Extensions.SkillsControllerName, Extensions.SkillName_Agility, _controller, _action);

            //Combat
            Extensions.ValidateClickByID(AssemblyFile.driver, "CombatLinkSkillsIndex", Extensions.SkillsControllerName, Extensions.SkillName_CombatSkills, _controller, _action);

            //Construction
            Extensions.ValidateClickByID(AssemblyFile.driver, "ConstructionLinkSkillsIndex", Extensions.SkillsControllerName, Extensions.SkillName_Construction, _controller, _action);

            //Cooking
            Extensions.ValidateClickByID(AssemblyFile.driver, "CookingLinkSkillsIndex", Extensions.SkillsControllerName, Extensions.SkillName_Cooking, _controller, _action);

            //Crafting
            Extensions.ValidateClickByID(AssemblyFile.driver, "CraftingLinkSkillsIndex", Extensions.SkillsControllerName, Extensions.SkillName_Crafting, _controller, _action);

            //Farming
            Extensions.ValidateClickByID(AssemblyFile.driver, "FarmingLinkSkillsIndex", Extensions.SkillsControllerName, Extensions.SkillName_Farming, _controller, _action);

            //Firemaking
            Extensions.ValidateClickByID(AssemblyFile.driver, "FiremakingLinkSkillsIndex", Extensions.SkillsControllerName, Extensions.SkillName_Firemaking, _controller, _action);

            //Fishing
            Extensions.ValidateClickByID(AssemblyFile.driver, "FishingLinkSkillsIndex", Extensions.SkillsControllerName, Extensions.SkillName_Fishing, _controller, _action);

            //Fletching
            Extensions.ValidateClickByID(AssemblyFile.driver, "FletchingLinkSkillsIndex", Extensions.SkillsControllerName, Extensions.SkillName_Fletching, _controller, _action);

            //Herblore
            Extensions.ValidateClickByID(AssemblyFile.driver, "HerbloreLinkSkillsIndex", Extensions.SkillsControllerName, Extensions.SkillName_Herblore, _controller, _action);

            //Hunter
            Extensions.ValidateClickByID(AssemblyFile.driver, "HunterLinkSkillsIndex", Extensions.SkillsControllerName, Extensions.SkillName_Hunter, _controller, _action);

            //Magic
            Extensions.ValidateClickByID(AssemblyFile.driver, "MagicLinkSkillsIndex", Extensions.SkillsControllerName, Extensions.SkillName_Magic, _controller, _action);

            //Mining
            Extensions.ValidateClickByID(AssemblyFile.driver, "MiningLinkSkillsIndex", Extensions.SkillsControllerName, Extensions.SkillName_Mining, _controller, _action);

            //Prayer
            Extensions.ValidateClickByID(AssemblyFile.driver, "PrayerLinkSkillsIndex", Extensions.SkillsControllerName, Extensions.SkillName_Prayer, _controller, _action);

            //Runecrafting
            Extensions.ValidateClickByID(AssemblyFile.driver, "RunecraftingLinkSkillsIndex", Extensions.SkillsControllerName, Extensions.SkillName_Runecrafting, _controller, _action);

            //Slayer
            Extensions.ValidateClickByID(AssemblyFile.driver, "SlayerLinkSkillsIndex", Extensions.SkillsControllerName, Extensions.SkillName_Slayer, _controller, _action);

            //Smithing
            Extensions.ValidateClickByID(AssemblyFile.driver, "SmithingLinkSkillsIndex", Extensions.SkillsControllerName, Extensions.SkillName_Smithing, _controller, _action);

            //Thieving
            Extensions.ValidateClickByID(AssemblyFile.driver, "ThievingLinkSkillsIndex", Extensions.SkillsControllerName, Extensions.SkillName_Thieving, _controller, _action);

            //Woodcutting
            Extensions.ValidateClickByID(AssemblyFile.driver, "WoodcuttingLinkSkillsIndex", Extensions.SkillsControllerName, Extensions.SkillName_Woodcutting, _controller, _action);
        }
    }
}
