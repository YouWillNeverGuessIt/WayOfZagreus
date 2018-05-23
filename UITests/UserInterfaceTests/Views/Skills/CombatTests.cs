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
    [TestClass]
    public class CombatTests
    {
        //these two string are used to match these tests to this 
        //  controller/action pair
        public static string _controller = Extensions.SkillsControllerName;
        public static string _action = Extensions.SkillName_CombatSkills;


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
        public void Skills_Combat_ClickAllLinks_NoLogin()
        {

            //validate all links to on site pages
            Extensions.ValidateClickByID(AssemblyFile.driver, "FishingLinkSkillsCombat_1", Extensions.SkillsControllerName, Extensions.SkillName_Fishing, _controller, _action);
            Extensions.ValidateClickByID(AssemblyFile.driver, "CraftingLinkSkillsCombat_1", Extensions.SkillsControllerName, Extensions.SkillName_Crafting, _controller, _action);
            Extensions.ValidateClickByID(AssemblyFile.driver, "SmithingLinkSkillsCombat_1", Extensions.SkillsControllerName, Extensions.SkillName_Smithing, _controller, _action);
            Extensions.ValidateClickByID(AssemblyFile.driver, "CraftingLinkSkillsCombat_2", Extensions.SkillsControllerName, Extensions.SkillName_Crafting, _controller, _action);
            Extensions.ValidateClickByID(AssemblyFile.driver, "RunecraftingLinkSkillsCombat_1", Extensions.SkillsControllerName, Extensions.SkillName_Runecrafting, _controller, _action);
            Extensions.ValidateClickByID(AssemblyFile.driver, "RunecraftingLinkSkillsCombat_2", Extensions.SkillsControllerName, Extensions.SkillName_Runecrafting, _controller, _action);


        }
    }
}
