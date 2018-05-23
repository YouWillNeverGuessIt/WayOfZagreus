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
            Extensions.ValidateClickByID(AssemblyFile.driver, "CookingLinkTimelineIndex21May2018_1", Extensions.SkillsControllerName, Extensions.SkillName_Cooking, _controller, _action);

            Extensions.ValidateClickByID(AssemblyFile.driver, "FishingLinkTimelineIndex20May2018_1", Extensions.SkillsControllerName, Extensions.SkillName_Fishing, _controller, _action);

            Extensions.ValidateClickByID(AssemblyFile.driver, "CraftingLinkTimelineIndex19May2018_1", Extensions.SkillsControllerName, Extensions.SkillName_Crafting, _controller, _action);

            Extensions.ValidateClickByID(AssemblyFile.driver, "RunecraftingLinkTimelineIndex14May2018_1", Extensions.SkillsControllerName, Extensions.SkillName_Runecrafting, _controller, _action);

            Extensions.ValidateClickByID(AssemblyFile.driver, "CookingLinkTimelineIndex11May2018_1", Extensions.SkillsControllerName, Extensions.SkillName_Cooking, _controller, _action);

            Extensions.ValidateClickByID(AssemblyFile.driver, "FishingLinkTimelineIndex10May2018_1", Extensions.SkillsControllerName, Extensions.SkillName_Fishing, _controller, _action);

            Extensions.ValidateClickByID(AssemblyFile.driver, "FishingLinkTimelineIndexApril2018_1", Extensions.SkillsControllerName, Extensions.SkillName_Fishing, _controller, _action);

            Extensions.ValidateClickByID(AssemblyFile.driver, "CookingLinkTimelineIndexApril2018_1", Extensions.SkillsControllerName, Extensions.SkillName_Cooking, _controller, _action);

            Extensions.ValidateClickByID(AssemblyFile.driver, "FishingLinkTimelineIndexSept2017_1", Extensions.SkillsControllerName, Extensions.SkillName_Fishing, _controller, _action);

            Extensions.ValidateClickByID(AssemblyFile.driver, "CookingLinkTimelineIndexSept2017_1", Extensions.SkillsControllerName, Extensions.SkillName_Cooking, _controller, _action);

            Extensions.ValidateClickByID(AssemblyFile.driver, "FishingLinkTimelineIndexSept2017_2", Extensions.SkillsControllerName, Extensions.SkillName_Fishing, _controller, _action);

            Extensions.ValidateClickByID(AssemblyFile.driver, "FishingLinkTimelineIndexSept2017_3", Extensions.SkillsControllerName, Extensions.SkillName_Fishing, _controller, _action);

            Extensions.ValidateClickByID(AssemblyFile.driver, "MiningLinkTimelineIndexSept2017_1", Extensions.SkillsControllerName, Extensions.SkillName_Mining, _controller, _action);

            Extensions.ValidateClickByID(AssemblyFile.driver, "CraftingLinkTimelineIndexSept2017_1", Extensions.SkillsControllerName, Extensions.SkillName_Crafting, _controller, _action);

            Extensions.ValidateClickByID(AssemblyFile.driver, "RunecraftingLinkTimelineIndexSept2017_1", Extensions.SkillsControllerName, Extensions.SkillName_Runecrafting, _controller, _action);

            Extensions.ValidateClickByID(AssemblyFile.driver, "RunecraftingLinkTimelineIndexSept2017_2", Extensions.SkillsControllerName, Extensions.SkillName_Runecrafting, _controller, _action);

            Extensions.ValidateClickByID(AssemblyFile.driver, "ConstructionLinkTimelineIndexAug2017_1", Extensions.SkillsControllerName, Extensions.SkillName_Construction, _controller, _action);

            Extensions.ValidateClickByID(AssemblyFile.driver, "SkillsLinkTimelineIndexAug2017_1", Extensions.SkillsControllerName, Extensions.SkillName_OverallSkills, _controller, _action);

            Extensions.ValidateClickByID(AssemblyFile.driver, "CombatLinkTimelineIndexAug2017_1", Extensions.SkillsControllerName, Extensions.SkillName_CombatSkills, _controller, _action);

            Extensions.ValidateClickByID(AssemblyFile.driver, "SmithingLinkTimelineIndexAug2017_1", Extensions.SkillsControllerName, Extensions.SkillName_Smithing, _controller, _action);

            Extensions.ValidateClickByID(AssemblyFile.driver, "SmithingLinkTimelineIndexAug2017_2", Extensions.SkillsControllerName, Extensions.SkillName_Smithing, _controller, _action);

            Extensions.ValidateClickByID(AssemblyFile.driver, "SmithingLinkTimelineIndexAug2017_3", Extensions.SkillsControllerName, Extensions.SkillName_Smithing, _controller, _action);

            Extensions.ValidateClickByID(AssemblyFile.driver, "SkillsLinkTimelineIndexJuly2017_1", Extensions.SkillsControllerName, Extensions.SkillName_OverallSkills, _controller, _action);


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
