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
    class Extensions
    {
        #region Variables
        //urls to use for testing
        public static string LiveBaseUrl = "https://zagreus2.azurewebsites.net";
        public static string LocalBaseUrl = "http://localhost:31894";//still need to set a port number to use when performing local testing, right now it uses any available port
        //add functionality later to perform a check for local or live testing, probably a something that checks if local is available and if not uses the live url
        public static string BaseUrl = LocalBaseUrl;//this should be what is used everywhere. the other two should only be used in the check function for local or live

        //the chromedriver.exe location
        public static string LocalChromeDriverLocation = "C:/Users/The Salty Spitoon/Desktop/MyFirstRealWebSite/dotnet-sqldb-tutorial-master/UITests/UserInterfaceTests/packages";

        //waiting times for a page to load
        public static int ShortWaitTime = 5;
        public static int LongWaitTime = 10;

        //controller names
        public static string TheWordController = "Controller";
        public static string SkillsControllerName = "Skills";
        public static string HomeControllerName = "Home";
        public static string TimelineControllerName = "Timeline";

        //main reference name for each view folder
        //this is basically a variable for the word index so that all 
        //  hard-coding is done in this file
        public static string TheWordIndex = "Index";

        //Skills names
        public static string SkillName_Agility = "Agility";
        public static string SkillName_Attack = "Attack";
        public static string SkillName_Construction = "Construction";
        public static string SkillName_Cooking = "Cooking";
        public static string SkillName_Crafting = "Crafting";
        public static string SkillName_Defense = "Defense";
        public static string SkillName_Farming = "Farming";
        public static string SkillName_Firemaking = "Firemaking";
        public static string SkillName_Fishing = "Fishing";
        public static string SkillName_Fletching = "Fletching";
        public static string SkillName_Herblore = "Herblore";
        public static string SKillName_Hitpoints = "Hitpoints";
        public static string SkillName_Hunter = "Hunter";
        public static string SkillName_Magic = "Magic";
        public static string SkillName_Mining = "Mining";
        public static string SkillName_Prayer = "Prayer";
        public static string SkillName_Range = "Range";
        public static string SkillName_Runecrafting = "Runecrafting";
        public static string SkillName_Slayer = "Slayer";
        public static string SkillName_Smithing = "Smithing";
        public static string SkillName_Strength = "Strength";
        public static string SkillName_Thieving = "Thieving";
        public static string SkillName_Woodcutting = "Woodcutting";
        public static string SkillName_OverallSkills = "Index";
        public static string SkillName_CombatSkills = "Combat";


        #endregion

        #region ids
        //[LandingPage]Link[CurrentController][CurrentView][unique info if needed]

        //for the link to zagreus420 hiscores
        public static string LinkToOSRSHiscores_SkillsIndexID = "osrsHiscoresLink";
        //for the actual osrs hiscores page (the jagex website, not mine)
        public static string OSRSHiscoresZagreus420_ID = "contentHiscores";

        //for the link to my google sheet
        public static string LinkToMyGoogleSheet_HomeIndexID = "GoogleSheetsosrsSheetLink";
        //for the actual google sheets page. It should display the sheet, but 
        //  you can't edit it. only I can do that 
        public static string GoogleSheetsOSRSSheet_ID = "docs-title-widget";

        //nav bar items
        public static string NavBar_HomeLinkID = "HomeLinkNavBar";
        public static string NavBar_SkillsLinkID = "SkillsLinkNavBar";
        public static string NavBar_TimelineLinkID = "TimelineLinkNavBar";

        //image map for images of skills
        public static string SkillsMap_ID = "SkillsMap";
        public static string SkillsMap_AttackID = "SkillsMap_Attack";
        public static string SkillsMap_HitpointsID = "SkillsMap_Hitpoints";
        public static string SkillsMap_MiningID = "SkillsMap_Mining";
        public static string SkillsMap_StrengthID = "SkillsMap_Strength";
        public static string SkillsMap_AgilityID = "SkillsMap_Agility";
        public static string SkillsMap_SmithingID = "SkillsMap_Smithing";
        public static string SkillsMap_DefenseID = "SkillsMap_Defense";
        public static string SkillsMap_HerbloreID = "SkillsMap_Herblore";
        public static string SkillsMap_FishingID = "SkillsMap_Fishing";
        public static string SkillsMap_RangeID = "SkillsMap_Range";
        public static string SkillsMap_ThievingID = "SkillsMap_Thieving";
        public static string SkillsMap_CookingID = "SkillsMap_Cooking";
        public static string SkillsMap_PrayerID = "SkillsMap_Prayer";
        public static string SkillsMap_CraftingID = "SkillsMap_Crafting";
        public static string SkillsMap_FiremakingID = "SkillsMap_Firemaking";
        public static string SkillsMap_MagicID = "SkillsMap_Magic";
        public static string SkillsMap_FletchingID = "SkillsMap_Fletching";
        public static string SkillsMap_WoodcuttingID = "SkillsMap_Woodcutting";
        public static string SkillsMap_RunecraftingID = "SkillsMap_Runecrafting";
        public static string SkillsMap_SlayerID = "SkillsMap_Slayer";
        public static string SkillsMap_FarmingID = "SkillsMap_Farming";
        public static string SkillsMap_ConstructionID = "SkillsMap_Construction";
        public static string SkillsMap_HunterID = "SkillsMap_Hunter";
        public static string SkillsMap_OverallID = "SkillsMap_Overall";

        //images of skills
        public static string SkillsImage_10May2018ID = "Stats_Image10May2018";
        public static string SkillsImage_April2018ID = "Stats_ImageApril2018";


        #endregion

        #region Functions
        //Used to validate that the page navigated to is the correct page. This
        //  checks the 4 tags that are placed on all view pages. an ID tag for 
        //  the page, area, controller, and action will be displayed on all 
        //  pages, simply check for those being what are expected, and boom 
        //  you've got page validation.
        //Returns true unless page validation failed
        public static bool ValidatePageTransition(IWebDriver driver, string controller, string action, string data = null)
        {
            var PageResult = driver.FindElement(By.Id("Page-Done"));
            var AreaResult = driver.FindElement(By.Id("Area--Done"));
            var ControllerResult = driver.FindElement(By.Id("Controller-" + controller + "-Done"));
            var ViewResult = driver.FindElement(By.Id("View-" + action + "-Done"));

            return true;
        }

        //Navigates the webdriver to the controller/action and any data 
        //  possibly attached to that if needed. This has the page validation
        //  function built into it. 
        //This should be used for all navigation done within the website. 
        //  Navigation to pages outside the website should be done using a 
        //  different functionality.
        //Returns true unless navigation failed, either due to validation 
        //  failure or another cause
        public static bool NavigateToPage(IWebDriver driver, string controller, string action, string data = null)
        {

            //navigate to the kenworth page
            driver.Navigate().GoToUrl(BaseUrl + "/" + controller + "/" + action + "/" + data);

            //check that page is the right page
            ValidatePageTransition(driver, controller, action);

            return true;
        }

        //Finds the given ID on the page, clicks it, validates the link landed
        //  on the correct page, and returns to original page
        //This function was made purely to follow the DRY principle
        //  Don't Repeat Yourself
        //  because even though your life should be wet, code needs to be DRY 
        //  to work. and there was a SHITTY TON of repeated code before this
        //Returns true unless validation failed
        public static bool ValidateClickByID(IWebDriver driver, string idToFind, string destController, string destAction, string origController, string origAction, string destData = null, string origData = null)
        {
            //find and click the given ID on the page
            driver.FindElement(By.Id(idToFind)).Click();
            //validate that the correct page was landed on
            ValidatePageTransition(driver, destController, destAction, destData);
            //return to original page
            NavigateToPage(driver, origController, origAction, origData);

            return true;
        }


        #endregion
    }
}
