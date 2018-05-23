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

namespace UserInterfaceTests.Views.Shared
{
    class Layout
    {

        //clicks all links in the nav bar. Right now this should include:
        //  Home
        //  Skills
        //  Timeline
        //  ADD TO THIS ASSHOLE whenever you need to obviously
        public static void NavBar_ClickAllLinks(IWebDriver currentDriver, string controller, string action, string data = null)
        {
            //navigate to home
            Extensions.ValidateClickByID(AssemblyFile.driver, Extensions.NavBar_HomeLinkID, Extensions.HomeControllerName, Extensions.TheWordIndex, controller, action);

            //navigate to skills
            Extensions.ValidateClickByID(AssemblyFile.driver, Extensions.NavBar_SkillsLinkID, Extensions.SkillsControllerName, Extensions.TheWordIndex, controller, action);

            //navigate to Timeline
            Extensions.ValidateClickByID(AssemblyFile.driver, Extensions.NavBar_TimelineLinkID, Extensions.TimelineControllerName, Extensions.TheWordIndex, controller, action);
        }

        //Clicks all links provided by the skills map. The skills map is what 
        //  allows all images of my skills to be clicked on and take the user 
        //  to the skill page. So, every skill should be clicked, including the
        //  overall skill total link.
        //This current functionality will not work with the timeline page. That
        //  is because there are multiple images with this image map on that 
        //  page. Find a better way to do this for multiple images on one page.
        public static void SkillsMap_ClickAllLinks(IWebDriver currentDriver, string controller, string action, string data = null)
        {
            //first check that the skills map even exists
            currentDriver.FindElement(By.Id(Extensions.SkillsMap_ID));

            //Attack
            currentDriver.FindElement(By.Id(Extensions.SkillsMap_AttackID)).Click();
            //validate
            Extensions.ValidatePageTransition(currentDriver, Extensions.SkillsControllerName, Extensions.SkillName_CombatSkills);
            //return to original page
            Extensions.NavigateToPage(currentDriver, controller, action, data);

            //Hitpoints
            currentDriver.FindElement(By.Id(Extensions.SkillsMap_HitpointsID)).Click();
            //validate
            Extensions.ValidatePageTransition(currentDriver, Extensions.SkillsControllerName, Extensions.SkillName_CombatSkills);
            //return to original page
            Extensions.NavigateToPage(currentDriver, controller, action, data);

            //Mining
            currentDriver.FindElement(By.Id(Extensions.SkillsMap_MiningID)).Click();
            //validate
            Extensions.ValidatePageTransition(currentDriver, Extensions.SkillsControllerName, Extensions.SkillName_Mining);
            //return to original page
            Extensions.NavigateToPage(currentDriver, controller, action, data);

            //Strength
            currentDriver.FindElement(By.Id(Extensions.SkillsMap_StrengthID)).Click();
            //validate
            Extensions.ValidatePageTransition(currentDriver, Extensions.SkillsControllerName, Extensions.SkillName_CombatSkills);
            //return to original page
            Extensions.NavigateToPage(currentDriver, controller, action, data);

            //Agility
            currentDriver.FindElement(By.Id(Extensions.SkillsMap_AgilityID)).Click();
            //validate
            Extensions.ValidatePageTransition(currentDriver, Extensions.SkillsControllerName, Extensions.SkillName_Agility);
            //return to original page
            Extensions.NavigateToPage(currentDriver, controller, action, data);

            //Smithing
            currentDriver.FindElement(By.Id(Extensions.SkillsMap_SmithingID)).Click();
            //validate
            Extensions.ValidatePageTransition(currentDriver, Extensions.SkillsControllerName, Extensions.SkillName_Smithing);
            //return to original page
            Extensions.NavigateToPage(currentDriver, controller, action, data);

            //Defense
            currentDriver.FindElement(By.Id(Extensions.SkillsMap_DefenseID)).Click();
            //validate
            Extensions.ValidatePageTransition(currentDriver, Extensions.SkillsControllerName, Extensions.SkillName_CombatSkills);
            //return to original page
            Extensions.NavigateToPage(currentDriver, controller, action, data);

            //Herblore
            currentDriver.FindElement(By.Id(Extensions.SkillsMap_HerbloreID)).Click();
            //validate
            Extensions.ValidatePageTransition(currentDriver, Extensions.SkillsControllerName, Extensions.SkillName_Herblore);
            //return to original page
            Extensions.NavigateToPage(currentDriver, controller, action, data);

            //Fishing
            currentDriver.FindElement(By.Id(Extensions.SkillsMap_FishingID)).Click();
            //validate
            Extensions.ValidatePageTransition(currentDriver, Extensions.SkillsControllerName, Extensions.SkillName_Fishing);
            //return to original page
            Extensions.NavigateToPage(currentDriver, controller, action, data);

            //Range
            currentDriver.FindElement(By.Id(Extensions.SkillsMap_RangeID)).Click();
            //validate
            Extensions.ValidatePageTransition(currentDriver, Extensions.SkillsControllerName, Extensions.SkillName_CombatSkills);
            //return to original page
            Extensions.NavigateToPage(currentDriver, controller, action, data);

            //Thieving
            currentDriver.FindElement(By.Id(Extensions.SkillsMap_ThievingID)).Click();
            //validate
            Extensions.ValidatePageTransition(currentDriver, Extensions.SkillsControllerName, Extensions.SkillName_Thieving);
            //return to original page
            Extensions.NavigateToPage(currentDriver, controller, action, data);

            //Cooking
            currentDriver.FindElement(By.Id(Extensions.SkillsMap_CookingID)).Click();
            //validate
            Extensions.ValidatePageTransition(currentDriver, Extensions.SkillsControllerName, Extensions.SkillName_Cooking);
            //return to original page
            Extensions.NavigateToPage(currentDriver, controller, action, data);

            //Prayer
            currentDriver.FindElement(By.Id(Extensions.SkillsMap_PrayerID)).Click();
            //validate
            Extensions.ValidatePageTransition(currentDriver, Extensions.SkillsControllerName, Extensions.SkillName_Prayer);
            //return to original page
            Extensions.NavigateToPage(currentDriver, controller, action, data);

            //Crafting
            currentDriver.FindElement(By.Id(Extensions.SkillsMap_CraftingID)).Click();
            //validate
            Extensions.ValidatePageTransition(currentDriver, Extensions.SkillsControllerName, Extensions.SkillName_Crafting);
            //return to original page
            Extensions.NavigateToPage(currentDriver, controller, action, data);

            //Firemaking
            currentDriver.FindElement(By.Id(Extensions.SkillsMap_FiremakingID)).Click();
            //validate
            Extensions.ValidatePageTransition(currentDriver, Extensions.SkillsControllerName, Extensions.SkillName_Firemaking);
            //return to original page
            Extensions.NavigateToPage(currentDriver, controller, action, data);

            //Magic
            currentDriver.FindElement(By.Id(Extensions.SkillsMap_MagicID)).Click();
            //validate
            Extensions.ValidatePageTransition(currentDriver, Extensions.SkillsControllerName, Extensions.SkillName_Magic);
            //return to original page
            Extensions.NavigateToPage(currentDriver, controller, action, data);

            //Fletching
            currentDriver.FindElement(By.Id(Extensions.SkillsMap_FletchingID)).Click();
            //validate
            Extensions.ValidatePageTransition(currentDriver, Extensions.SkillsControllerName, Extensions.SkillName_Fletching);
            //return to original page
            Extensions.NavigateToPage(currentDriver, controller, action, data);

            //Woodcutting
            currentDriver.FindElement(By.Id(Extensions.SkillsMap_WoodcuttingID)).Click();
            //validate
            Extensions.ValidatePageTransition(currentDriver, Extensions.SkillsControllerName, Extensions.SkillName_Woodcutting);
            //return to original page
            Extensions.NavigateToPage(currentDriver, controller, action, data);

            //Runecrafting
            currentDriver.FindElement(By.Id(Extensions.SkillsMap_RunecraftingID)).Click();
            //validate
            Extensions.ValidatePageTransition(currentDriver, Extensions.SkillsControllerName, Extensions.SkillName_Runecrafting);
            //return to original page
            Extensions.NavigateToPage(currentDriver, controller, action, data);

            //Slayer
            currentDriver.FindElement(By.Id(Extensions.SkillsMap_SlayerID)).Click();
            //validate
            Extensions.ValidatePageTransition(currentDriver, Extensions.SkillsControllerName, Extensions.SkillName_Slayer);
            //return to original page
            Extensions.NavigateToPage(currentDriver, controller, action, data);

            //Farming
            currentDriver.FindElement(By.Id(Extensions.SkillsMap_FarmingID)).Click();
            //validate
            Extensions.ValidatePageTransition(currentDriver, Extensions.SkillsControllerName, Extensions.SkillName_Farming);
            //return to original page
            Extensions.NavigateToPage(currentDriver, controller, action, data);

            //Construction
            currentDriver.FindElement(By.Id(Extensions.SkillsMap_ConstructionID)).Click();
            //validate
            Extensions.ValidatePageTransition(currentDriver, Extensions.SkillsControllerName, Extensions.SkillName_Construction);
            //return to original page
            Extensions.NavigateToPage(currentDriver, controller, action, data);

            //Hunter
            currentDriver.FindElement(By.Id(Extensions.SkillsMap_HunterID)).Click();
            //validate
            Extensions.ValidatePageTransition(currentDriver, Extensions.SkillsControllerName, Extensions.SkillName_Hunter);
            //return to original page
            Extensions.NavigateToPage(currentDriver, controller, action, data);

            //Overall
            currentDriver.FindElement(By.Id(Extensions.SkillsMap_OverallID)).Click();
            //validate
            Extensions.ValidatePageTransition(currentDriver, Extensions.SkillsControllerName, Extensions.SkillName_OverallSkills);
            //return to original page
            Extensions.NavigateToPage(currentDriver, controller, action, data);
        }

        //clicks and validates all links inside the footer
        //fails if any links fail
        public static void Footer_ClickAllLinks(IWebDriver currentDriver, string controller, string action, string data = null)
        {
            //Click the about the author link
            currentDriver.FindElement(By.Id("AboutLinkFooter")).Click();
            //validate page transition
            Extensions.ValidatePageTransition(currentDriver, Extensions.HomeControllerName, "About");
            //return to original page
            Extensions.NavigateToPage(currentDriver, controller, action, data);
        }
    }
}
