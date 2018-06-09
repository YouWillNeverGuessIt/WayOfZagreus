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

namespace UserInterfaceTests.Views.Skills
{
    //This is really just a test for the sidebar
    //  but the sidebar resides in _SkillsLayout, so I put these tests 
    //  it's own file for UI testing clarity
    class _SkillsLayout
    {
        public static void SideBar_ClickAllLinks(IWebDriver currentDriver, string controller, string action, string data = null)
        {
            //Overall
            Extensions.ValidateClickByID(AssemblyFile.driver, "SkillsLinkSideBar", Extensions.SkillsControllerName, Extensions.SkillName_OverallSkills, controller, action);

            //Mining
            Extensions.ValidateClickByID(AssemblyFile.driver, "MiningLinkSideBar", Extensions.SkillsControllerName, Extensions.SkillName_Mining, controller, action);

            //Agility
            Extensions.ValidateClickByID(AssemblyFile.driver, "AgilityLinkSideBar", Extensions.SkillsControllerName, Extensions.SkillName_Agility, controller, action);

            //Smithing
            Extensions.ValidateClickByID(AssemblyFile.driver, "SmithingLinkSideBar", Extensions.SkillsControllerName, Extensions.SkillName_Smithing, controller, action);

            //Herblore
            Extensions.ValidateClickByID(AssemblyFile.driver, "HerbloreLinkSideBar", Extensions.SkillsControllerName, Extensions.SkillName_Herblore, controller, action);

            //Fishing
            Extensions.ValidateClickByID(AssemblyFile.driver, "FishingLinkSideBar", Extensions.SkillsControllerName, Extensions.SkillName_Fishing, controller, action);

            //Thieving
            Extensions.ValidateClickByID(AssemblyFile.driver, "ThievingLinkSideBar", Extensions.SkillsControllerName, Extensions.SkillName_Thieving, controller, action);

            //Cooking
            Extensions.ValidateClickByID(AssemblyFile.driver, "CookingLinkSideBar", Extensions.SkillsControllerName, Extensions.SkillName_Cooking, controller, action);

            //Prayer
            Extensions.ValidateClickByID(AssemblyFile.driver, "PrayerLinkSideBar", Extensions.SkillsControllerName, Extensions.SkillName_Prayer, controller, action);

            //Crafting
            Extensions.ValidateClickByID(AssemblyFile.driver, "CraftingLinkSideBar", Extensions.SkillsControllerName, Extensions.SkillName_Crafting, controller, action);

            //Firemaking
            Extensions.ValidateClickByID(AssemblyFile.driver, "FiremakingLinkSideBar", Extensions.SkillsControllerName, Extensions.SkillName_Firemaking, controller, action);

            //Magic
            Extensions.ValidateClickByID(AssemblyFile.driver, "MagicLinkSideBar", Extensions.SkillsControllerName, Extensions.SkillName_Magic, controller, action);

            //Fletching
            Extensions.ValidateClickByID(AssemblyFile.driver, "FletchingLinkSideBar", Extensions.SkillsControllerName, Extensions.SkillName_Fletching, controller, action);

            //Woodcutting
            Extensions.ValidateClickByID(AssemblyFile.driver, "WoodcuttingLinkSideBar", Extensions.SkillsControllerName, Extensions.SkillName_Woodcutting, controller, action);

            //Runecrafting
            Extensions.ValidateClickByID(AssemblyFile.driver, "RunecraftingLinkSideBar", Extensions.SkillsControllerName, Extensions.SkillName_Runecrafting, controller, action);

            //Slayer
            Extensions.ValidateClickByID(AssemblyFile.driver, "SlayerLinkSideBar", Extensions.SkillsControllerName, Extensions.SkillName_Slayer, controller, action);

            //Farming
            Extensions.ValidateClickByID(AssemblyFile.driver, "FarmingLinkSideBar", Extensions.SkillsControllerName, Extensions.SkillName_Farming, controller, action);

            //Construction
            Extensions.ValidateClickByID(AssemblyFile.driver, "ConstructionLinkSideBar", Extensions.SkillsControllerName, Extensions.SkillName_Construction, controller, action);

            //Hunter
            Extensions.ValidateClickByID(AssemblyFile.driver, "HunterLinkSideBar", Extensions.SkillsControllerName, Extensions.SkillName_Hunter, controller, action);
        }

    }
}
