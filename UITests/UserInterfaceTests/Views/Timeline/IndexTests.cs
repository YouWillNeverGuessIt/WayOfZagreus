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

namespace UserInterfaceTests.Views.Timeline
{
    [TestClass]
    public class IndexTests
    {
        //these two string are used to match these tests to this 
        //  controller/action pair
        public static string _controller = Extensions.TimelineControllerName;
        public static string _action = Extensions.TheWordIndex;

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
        public void Timeline_Index_ClickAllLinks_NoLogin()
        {
            //there are currently only two images, but both of them have tons of links to test
            //BUT that doesn't matter! because techincally, skillsmap only appears once on the html page, and multiple images use that map
            // so the skills map once and test that the images simply exist
            //you'll have to find a better way to test that the size of each box in the skill map is correct
            
            //check that the skills map works
            Shared.Layout.SkillsMap_ClickAllLinks(AssemblyFile.driver, _controller, _action);

            //check that each image exists
            AssemblyFile.driver.FindElement(By.Id("Stats_Image21May2018"));
            AssemblyFile.driver.FindElement(By.Id("Stats_Image20May2018"));
            AssemblyFile.driver.FindElement(By.Id("Stats_Image19May2018"));
            AssemblyFile.driver.FindElement(By.Id("Stats_Image14May2018"));
            AssemblyFile.driver.FindElement(By.Id("Stats_Image11May2018"));
            AssemblyFile.driver.FindElement(By.Id(Extensions.SkillsImage_10May2018ID));
            AssemblyFile.driver.FindElement(By.Id(Extensions.SkillsImage_April2018ID));

            //check that links to onsite pages work

            AssemblyFile.driver.FindElement(By.Id("CookingLinkTimelineIndex21May2018_1")).Click();
            //validate
            Extensions.ValidatePageTransition(AssemblyFile.driver, Extensions.SkillsControllerName, Extensions.SkillName_Cooking);
            //return to original page
            Extensions.NavigateToPage(AssemblyFile.driver, _controller, _action);

            AssemblyFile.driver.FindElement(By.Id("FishingLinkTimelineIndex20May2018_1")).Click();
            //validate
            Extensions.ValidatePageTransition(AssemblyFile.driver, Extensions.SkillsControllerName, Extensions.SkillName_Fishing);
            //return to original page
            Extensions.NavigateToPage(AssemblyFile.driver, _controller, _action);

            AssemblyFile.driver.FindElement(By.Id("CraftingLinkTimelineIndex19May2018_1")).Click();
            //validate
            Extensions.ValidatePageTransition(AssemblyFile.driver, Extensions.SkillsControllerName, Extensions.SkillName_Crafting);
            //return to original page
            Extensions.NavigateToPage(AssemblyFile.driver, _controller, _action);

            AssemblyFile.driver.FindElement(By.Id("RunecraftingLinkTimelineIndex14May2018_1")).Click();
            //validate
            Extensions.ValidatePageTransition(AssemblyFile.driver, Extensions.SkillsControllerName, Extensions.SkillName_Runecrafting);
            //return to original page
            Extensions.NavigateToPage(AssemblyFile.driver, _controller, _action);

            AssemblyFile.driver.FindElement(By.Id("CookingLinkTimelineIndex11May2018_1")).Click();
            //validate
            Extensions.ValidatePageTransition(AssemblyFile.driver, Extensions.SkillsControllerName, Extensions.SkillName_Cooking);
            //return to original page
            Extensions.NavigateToPage(AssemblyFile.driver, _controller, _action);

            AssemblyFile.driver.FindElement(By.Id("FishingLinkTimelineIndex10May2018_1")).Click();
            //validate
            Extensions.ValidatePageTransition(AssemblyFile.driver, Extensions.SkillsControllerName, Extensions.SkillName_Fishing);
            //return to original page
            Extensions.NavigateToPage(AssemblyFile.driver, _controller, _action);

            AssemblyFile.driver.FindElement(By.Id("FishingLinkTimelineIndexApril2018_1")).Click();
            //validate
            Extensions.ValidatePageTransition(AssemblyFile.driver, Extensions.SkillsControllerName, Extensions.SkillName_Fishing);
            //return to original page
            Extensions.NavigateToPage(AssemblyFile.driver, _controller, _action);

            AssemblyFile.driver.FindElement(By.Id("CookingLinkTimelineIndexApril2018_1")).Click();
            //validate
            Extensions.ValidatePageTransition(AssemblyFile.driver, Extensions.SkillsControllerName, Extensions.SkillName_Cooking);
            //return to original page
            Extensions.NavigateToPage(AssemblyFile.driver, _controller, _action);

            AssemblyFile.driver.FindElement(By.Id("FishingLinkTimelineIndexSept2017_1")).Click();
            //validate
            Extensions.ValidatePageTransition(AssemblyFile.driver, Extensions.SkillsControllerName, Extensions.SkillName_Fishing);
            //return to original page
            Extensions.NavigateToPage(AssemblyFile.driver, _controller, _action);

            AssemblyFile.driver.FindElement(By.Id("CookingLinkTimelineIndexSept2017_1")).Click();
            //validate
            Extensions.ValidatePageTransition(AssemblyFile.driver, Extensions.SkillsControllerName, Extensions.SkillName_Cooking);
            //return to original page
            Extensions.NavigateToPage(AssemblyFile.driver, _controller, _action);

            AssemblyFile.driver.FindElement(By.Id("FishingLinkTimelineIndexSept2017_2")).Click();
            //validate
            Extensions.ValidatePageTransition(AssemblyFile.driver, Extensions.SkillsControllerName, Extensions.SkillName_Fishing);
            //return to original page
            Extensions.NavigateToPage(AssemblyFile.driver, _controller, _action);

            AssemblyFile.driver.FindElement(By.Id("FishingLinkTimelineIndexSept2017_3")).Click();
            //validate
            Extensions.ValidatePageTransition(AssemblyFile.driver, Extensions.SkillsControllerName, Extensions.SkillName_Fishing);
            //return to original page
            Extensions.NavigateToPage(AssemblyFile.driver, _controller, _action);

            AssemblyFile.driver.FindElement(By.Id("MiningLinkTimelineIndexSept2017_1")).Click();
            //validate
            Extensions.ValidatePageTransition(AssemblyFile.driver, Extensions.SkillsControllerName, Extensions.SkillName_Mining);
            //return to original page
            Extensions.NavigateToPage(AssemblyFile.driver, _controller, _action);

            AssemblyFile.driver.FindElement(By.Id("CraftingLinkTimelineIndexSept2017_1")).Click();
            //validate
            Extensions.ValidatePageTransition(AssemblyFile.driver, Extensions.SkillsControllerName, Extensions.SkillName_Crafting);
            //return to original page
            Extensions.NavigateToPage(AssemblyFile.driver, _controller, _action);

            AssemblyFile.driver.FindElement(By.Id("RunecraftingLinkTimelineIndexSept2017_1")).Click();
            //validate
            Extensions.ValidatePageTransition(AssemblyFile.driver, Extensions.SkillsControllerName, Extensions.SkillName_Runecrafting);
            //return to original page
            Extensions.NavigateToPage(AssemblyFile.driver, _controller, _action);

            AssemblyFile.driver.FindElement(By.Id("RunecraftingLinkTimelineIndexSept2017_2")).Click();
            //validate
            Extensions.ValidatePageTransition(AssemblyFile.driver, Extensions.SkillsControllerName, Extensions.SkillName_Runecrafting);
            //return to original page
            Extensions.NavigateToPage(AssemblyFile.driver, _controller, _action);

            AssemblyFile.driver.FindElement(By.Id("ConstructionLinkTimelineIndexAug2017_1")).Click();
            //validate
            Extensions.ValidatePageTransition(AssemblyFile.driver, Extensions.SkillsControllerName, Extensions.SkillName_Construction);
            //return to original page
            Extensions.NavigateToPage(AssemblyFile.driver, _controller, _action);

            AssemblyFile.driver.FindElement(By.Id("SkillsLinkTimelineIndexAug2017_1")).Click();
            //validate
            Extensions.ValidatePageTransition(AssemblyFile.driver, Extensions.SkillsControllerName, Extensions.SkillName_OverallSkills);
            //return to original page
            Extensions.NavigateToPage(AssemblyFile.driver, _controller, _action);

            AssemblyFile.driver.FindElement(By.Id("CombatLinkTimelineIndexAug2017_1")).Click();
            //validate
            Extensions.ValidatePageTransition(AssemblyFile.driver, Extensions.SkillsControllerName, Extensions.SkillName_CombatSkills);
            //return to original page
            Extensions.NavigateToPage(AssemblyFile.driver, _controller, _action);

            AssemblyFile.driver.FindElement(By.Id("SmithingLinkTimelineIndexAug2017_1")).Click();
            //validate
            Extensions.ValidatePageTransition(AssemblyFile.driver, Extensions.SkillsControllerName, Extensions.SkillName_Smithing);
            //return to original page
            Extensions.NavigateToPage(AssemblyFile.driver, _controller, _action);

            AssemblyFile.driver.FindElement(By.Id("SmithingLinkTimelineIndexAug2017_2")).Click();
            //validate
            Extensions.ValidatePageTransition(AssemblyFile.driver, Extensions.SkillsControllerName, Extensions.SkillName_Smithing);
            //return to original page
            Extensions.NavigateToPage(AssemblyFile.driver, _controller, _action);

            AssemblyFile.driver.FindElement(By.Id("SmithingLinkTimelineIndexAug2017_3")).Click();
            //validate
            Extensions.ValidatePageTransition(AssemblyFile.driver, Extensions.SkillsControllerName, Extensions.SkillName_Smithing);
            //return to original page
            Extensions.NavigateToPage(AssemblyFile.driver, _controller, _action);

            AssemblyFile.driver.FindElement(By.Id("SkillsLinkTimelineIndexJuly2017_1")).Click();
            //validate
            Extensions.ValidatePageTransition(AssemblyFile.driver, Extensions.SkillsControllerName, Extensions.SkillName_OverallSkills);
            //return to original page
            Extensions.NavigateToPage(AssemblyFile.driver, _controller, _action);



            //check that links to offsite pages work

            //check that the google sheets link works
            AssemblyFile.driver.FindElement(By.Id("GoogleSheetsosrsSheetLink_1")).Click();
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

            //click the second google sheets link
            AssemblyFile.driver.FindElement(By.Id("GoogleSheetsosrsSheetLink_2")).Click();
            //manually validate link to google sheets worked because it is an 
            //  off -site link. I do this by looking for the id 
            //  "docs-title-widget". This is a div object attached to the title
            //  of the sheet you are view. So hopefully that will not display 
            //  if you are not view a sheet. this might need some work to truly
            //  verify that the link has taken the user to the right place.
            //Should open in new tab
            browserTabs = AssemblyFile.driver.WindowHandles;
            AssemblyFile.driver.SwitchTo().Window(browserTabs[1]);
            AssemblyFile.driver.FindElement(By.Id(Extensions.GoogleSheetsOSRSSheet_ID));
            //close the new tab
            AssemblyFile.driver.Close();
            //return to original tab
            AssemblyFile.driver.SwitchTo().Window(browserTabs[0]);
        }
    }
}
