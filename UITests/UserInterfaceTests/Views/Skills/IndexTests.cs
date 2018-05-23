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
            AssemblyFile.driver.FindElement(By.Id("AgilityLinkSkillsIndex")).Click();
            //validate
            Extensions.ValidatePageTransition(AssemblyFile.driver, Extensions.SkillsControllerName, Extensions.SkillName_Agility);
            //return to original page
            Extensions.NavigateToPage(AssemblyFile.driver, _controller, _action);
            
            //Combat
            AssemblyFile.driver.FindElement(By.Id("CombatLinkSkillsIndex")).Click();
            //validate
            Extensions.ValidatePageTransition(AssemblyFile.driver, Extensions.SkillsControllerName, Extensions.SkillName_CombatSkills);
            //return to original page
            Extensions.NavigateToPage(AssemblyFile.driver, _controller, _action);
            
            //Construction
            AssemblyFile.driver.FindElement(By.Id("ConstructionLinkSkillsIndex")).Click();
            //validate
            Extensions.ValidatePageTransition(AssemblyFile.driver, Extensions.SkillsControllerName, Extensions.SkillName_Construction);
            //return to original page
            Extensions.NavigateToPage(AssemblyFile.driver, _controller, _action);
            
            //Cooking
            AssemblyFile.driver.FindElement(By.Id("CookingLinkSkillsIndex")).Click();
            //validate
            Extensions.ValidatePageTransition(AssemblyFile.driver, Extensions.SkillsControllerName, Extensions.SkillName_Cooking);
            //return to original page
            Extensions.NavigateToPage(AssemblyFile.driver, _controller, _action);
            
            //Crafting
            AssemblyFile.driver.FindElement(By.Id("CraftingLinkSkillsIndex")).Click();
            //validate
            Extensions.ValidatePageTransition(AssemblyFile.driver, Extensions.SkillsControllerName, Extensions.SkillName_Crafting);
            //return to original page
            Extensions.NavigateToPage(AssemblyFile.driver, _controller, _action);

            //Farming
            AssemblyFile.driver.FindElement(By.Id("FarmingLinkSkillsIndex")).Click();
            //validate
            Extensions.ValidatePageTransition(AssemblyFile.driver, Extensions.SkillsControllerName, Extensions.SkillName_Farming);
            //return to original page
            Extensions.NavigateToPage(AssemblyFile.driver, _controller, _action);

            //Firemaking
            AssemblyFile.driver.FindElement(By.Id("FiremakingLinkSkillsIndex")).Click();
            //validate
            Extensions.ValidatePageTransition(AssemblyFile.driver, Extensions.SkillsControllerName, Extensions.SkillName_Firemaking);
            //return to original page
            Extensions.NavigateToPage(AssemblyFile.driver, _controller, _action);

            //Fishing
            AssemblyFile.driver.FindElement(By.Id("FishingLinkSkillsIndex")).Click();
            //validate
            Extensions.ValidatePageTransition(AssemblyFile.driver, Extensions.SkillsControllerName, Extensions.SkillName_Fishing);
            //return to original page
            Extensions.NavigateToPage(AssemblyFile.driver, _controller, _action);

            //Fletching
            AssemblyFile.driver.FindElement(By.Id("FletchingLinkSkillsIndex")).Click();
            //validate
            Extensions.ValidatePageTransition(AssemblyFile.driver, Extensions.SkillsControllerName, Extensions.SkillName_Fletching);
            //return to original page
            Extensions.NavigateToPage(AssemblyFile.driver, _controller, _action);

            //Herblore
            AssemblyFile.driver.FindElement(By.Id("HerbloreLinkSkillsIndex")).Click();
            //validate
            Extensions.ValidatePageTransition(AssemblyFile.driver, Extensions.SkillsControllerName, Extensions.SkillName_Herblore);
            //return to original page
            Extensions.NavigateToPage(AssemblyFile.driver, _controller, _action);

            //Agility
            AssemblyFile.driver.FindElement(By.Id("HunterLinkSkillsIndex")).Click();
            //validate
            Extensions.ValidatePageTransition(AssemblyFile.driver, Extensions.SkillsControllerName, Extensions.SkillName_Hunter);
            //return to original page
            Extensions.NavigateToPage(AssemblyFile.driver, _controller, _action);

            //Magic
            AssemblyFile.driver.FindElement(By.Id("MagicLinkSkillsIndex")).Click();
            //validate
            Extensions.ValidatePageTransition(AssemblyFile.driver, Extensions.SkillsControllerName, Extensions.SkillName_Magic);
            //return to original page
            Extensions.NavigateToPage(AssemblyFile.driver, _controller, _action);

            //Mining
            AssemblyFile.driver.FindElement(By.Id("MiningLinkSkillsIndex")).Click();
            //validate
            Extensions.ValidatePageTransition(AssemblyFile.driver, Extensions.SkillsControllerName, Extensions.SkillName_Mining);
            //return to original page
            Extensions.NavigateToPage(AssemblyFile.driver, _controller, _action);

            //Prayer
            AssemblyFile.driver.FindElement(By.Id("PrayerLinkSkillsIndex")).Click();
            //validate
            Extensions.ValidatePageTransition(AssemblyFile.driver, Extensions.SkillsControllerName, Extensions.SkillName_Prayer);
            //return to original page
            Extensions.NavigateToPage(AssemblyFile.driver, _controller, _action);

            //Runecrafting
            AssemblyFile.driver.FindElement(By.Id("RunecraftingLinkSkillsIndex")).Click();
            //validate
            Extensions.ValidatePageTransition(AssemblyFile.driver, Extensions.SkillsControllerName, Extensions.SkillName_Runecrafting);
            //return to original page
            Extensions.NavigateToPage(AssemblyFile.driver, _controller, _action);

            //Slayer
            AssemblyFile.driver.FindElement(By.Id("SlayerLinkSkillsIndex")).Click();
            //validate
            Extensions.ValidatePageTransition(AssemblyFile.driver, Extensions.SkillsControllerName, Extensions.SkillName_Slayer);
            //return to original page
            Extensions.NavigateToPage(AssemblyFile.driver, _controller, _action);

            //Smithing
            AssemblyFile.driver.FindElement(By.Id("SmithingLinkSkillsIndex")).Click();
            //validate
            Extensions.ValidatePageTransition(AssemblyFile.driver, Extensions.SkillsControllerName, Extensions.SkillName_Smithing);
            //return to original page
            Extensions.NavigateToPage(AssemblyFile.driver, _controller, _action);

            //Thieving
            AssemblyFile.driver.FindElement(By.Id("ThievingLinkSkillsIndex")).Click();
            //validate
            Extensions.ValidatePageTransition(AssemblyFile.driver, Extensions.SkillsControllerName, Extensions.SkillName_Thieving);
            //return to original page
            Extensions.NavigateToPage(AssemblyFile.driver, _controller, _action);

            //Woodcutting
            AssemblyFile.driver.FindElement(By.Id("WoodcuttingLinkSkillsIndex")).Click();
            //validate
            Extensions.ValidatePageTransition(AssemblyFile.driver, Extensions.SkillsControllerName, Extensions.SkillName_Woodcutting);
            //return to original page
            Extensions.NavigateToPage(AssemblyFile.driver, _controller, _action);
        }
    }
}
