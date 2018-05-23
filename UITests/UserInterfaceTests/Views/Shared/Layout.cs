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
            Extensions.ValidateClickByID(AssemblyFile.driver, Extensions.SkillsMap_AttackID, Extensions.SkillsControllerName, Extensions.SkillName_CombatSkills, controller, action);

            //Hitpoints
            Extensions.ValidateClickByID(AssemblyFile.driver, Extensions.SkillsMap_HitpointsID, Extensions.SkillsControllerName, Extensions.SkillName_CombatSkills, controller, action);

            //Mining
            Extensions.ValidateClickByID(AssemblyFile.driver, Extensions.SkillsMap_MiningID, Extensions.SkillsControllerName, Extensions.SkillName_Mining, controller, action);

            //Strength
            Extensions.ValidateClickByID(AssemblyFile.driver, Extensions.SkillsMap_StrengthID, Extensions.SkillsControllerName, Extensions.SkillName_CombatSkills, controller, action);

            //Agility
            Extensions.ValidateClickByID(AssemblyFile.driver, Extensions.SkillsMap_AgilityID, Extensions.SkillsControllerName, Extensions.SkillName_Agility, controller, action);

            //Smithing
            Extensions.ValidateClickByID(AssemblyFile.driver, Extensions.SkillsMap_SmithingID, Extensions.SkillsControllerName, Extensions.SkillName_Smithing, controller, action);

            //Defense
            Extensions.ValidateClickByID(AssemblyFile.driver, Extensions.SkillsMap_DefenseID, Extensions.SkillsControllerName, Extensions.SkillName_CombatSkills, controller, action);

            //Herblore
            Extensions.ValidateClickByID(AssemblyFile.driver, Extensions.SkillsMap_HerbloreID, Extensions.SkillsControllerName, Extensions.SkillName_Herblore, controller, action);

            //Fishing
            Extensions.ValidateClickByID(AssemblyFile.driver, Extensions.SkillsMap_FishingID, Extensions.SkillsControllerName, Extensions.SkillName_Fishing, controller, action);

            //Range
            Extensions.ValidateClickByID(AssemblyFile.driver, Extensions.SkillsMap_RangeID, Extensions.SkillsControllerName, Extensions.SkillName_CombatSkills, controller, action);

            //Thieving
            Extensions.ValidateClickByID(AssemblyFile.driver, Extensions.SkillsMap_ThievingID, Extensions.SkillsControllerName, Extensions.SkillName_Thieving, controller, action);

            //Cooking
            Extensions.ValidateClickByID(AssemblyFile.driver, Extensions.SkillsMap_CookingID, Extensions.SkillsControllerName, Extensions.SkillName_Cooking, controller, action);

            //Prayer
            Extensions.ValidateClickByID(AssemblyFile.driver, Extensions.SkillsMap_PrayerID, Extensions.SkillsControllerName, Extensions.SkillName_Prayer, controller, action);

            //Crafting
            Extensions.ValidateClickByID(AssemblyFile.driver, Extensions.SkillsMap_CraftingID, Extensions.SkillsControllerName, Extensions.SkillName_Crafting, controller, action);

            //Firemaking
            Extensions.ValidateClickByID(AssemblyFile.driver, Extensions.SkillsMap_FiremakingID, Extensions.SkillsControllerName, Extensions.SkillName_Firemaking, controller, action);

            //Magic
            Extensions.ValidateClickByID(AssemblyFile.driver, Extensions.SkillsMap_MagicID, Extensions.SkillsControllerName, Extensions.SkillName_Magic, controller, action);

            //Fletching
            Extensions.ValidateClickByID(AssemblyFile.driver, Extensions.SkillsMap_FletchingID, Extensions.SkillsControllerName, Extensions.SkillName_Fletching, controller, action);

            //Woodcutting
            Extensions.ValidateClickByID(AssemblyFile.driver, Extensions.SkillsMap_WoodcuttingID, Extensions.SkillsControllerName, Extensions.SkillName_Woodcutting, controller, action);

            //Runecrafting
            Extensions.ValidateClickByID(AssemblyFile.driver, Extensions.SkillsMap_RunecraftingID, Extensions.SkillsControllerName, Extensions.SkillName_Runecrafting, controller, action);

            //Slayer
            Extensions.ValidateClickByID(AssemblyFile.driver, Extensions.SkillsMap_SlayerID, Extensions.SkillsControllerName, Extensions.SkillName_Slayer, controller, action);

            //Farming
            Extensions.ValidateClickByID(AssemblyFile.driver, Extensions.SkillsMap_FarmingID, Extensions.SkillsControllerName, Extensions.SkillName_Farming, controller, action);

            //Construction
            Extensions.ValidateClickByID(AssemblyFile.driver, Extensions.SkillsMap_ConstructionID, Extensions.SkillsControllerName, Extensions.SkillName_Construction, controller, action);

            //Hunter
            Extensions.ValidateClickByID(AssemblyFile.driver, Extensions.SkillsMap_HunterID, Extensions.SkillsControllerName, Extensions.SkillName_Hunter, controller, action);

            //Overall
            Extensions.ValidateClickByID(AssemblyFile.driver, Extensions.SkillsMap_OverallID, Extensions.SkillsControllerName, Extensions.SkillName_OverallSkills, controller, action);
        }

        //clicks and validates all links inside the footer
        //fails if any links fail
        public static void Footer_ClickAllLinks(IWebDriver currentDriver, string controller, string action, string data = null)
        {
            //Click the about the author link
            Extensions.ValidateClickByID(AssemblyFile.driver, "AboutLinkFooter", Extensions.HomeControllerName, "About", controller, action);

        }
    }
}
