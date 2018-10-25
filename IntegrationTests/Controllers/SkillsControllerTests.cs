using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using DotNetAppSqlDb.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntegrationTests.Controllers
{
    [TestClass]
    public class SkillsControllerTests
    {
        public TestContext TestContext { get; set; }

        #region Index
        [TestMethod]
        public void Controller_Skills_Index_Default_Should_Pass()
        {
            // Arrange
            SkillsController controller = new SkillsController();          

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result, TestContext.TestName);
        }
        #endregion IndexRegion

        #region Individual Skills
        [TestMethod]
        public void Controller_Skills_Agility_Default_Should_Pass()
        {
            // Arrange
            SkillsController controller = new SkillsController();

            // Act
            ViewResult result = controller.Agility() as ViewResult;

            // Assert
            Assert.IsNotNull(result, TestContext.TestName);
        }

        [TestMethod]
        public void Controller_Skills_Combat_Default_Should_Pass()
        {
            // Arrange
            SkillsController controller = new SkillsController();

            // Act
            ViewResult result = controller.Combat() as ViewResult;

            // Assert
            Assert.IsNotNull(result, TestContext.TestName);
        }

        [TestMethod]
        public void Controller_Skills_Construction_Default_Should_Pass()
        {
            // Arrange
            SkillsController controller = new SkillsController();

            // Act
            ViewResult result = controller.Construction() as ViewResult;

            // Assert
            Assert.IsNotNull(result, TestContext.TestName);
        }

        [TestMethod]
        public void Controller_Skills_Cooking_Default_Should_Pass()
        {
            // Arrange
            SkillsController controller = new SkillsController();

            // Act
            ViewResult result = controller.Cooking() as ViewResult;

            // Assert
            Assert.IsNotNull(result, TestContext.TestName);
        }

        [TestMethod]
        public void Controller_Skills_Crafting_Default_Should_Pass()
        {
            // Arrange
            SkillsController controller = new SkillsController();

            // Act
            ViewResult result = controller.Crafting() as ViewResult;

            // Assert
            Assert.IsNotNull(result, TestContext.TestName);
        }

        [TestMethod]
        public void Controller_Skills_Farming_Default_Should_Pass()
        {
            // Arrange
            SkillsController controller = new SkillsController();

            // Act
            ViewResult result = controller.Farming() as ViewResult;

            // Assert
            Assert.IsNotNull(result, TestContext.TestName);
        }

        [TestMethod]
        public void Controller_Skills_Firemaking_Default_Should_Pass()
        {
            // Arrange
            SkillsController controller = new SkillsController();

            // Act
            ViewResult result = controller.Firemaking() as ViewResult;

            // Assert
            Assert.IsNotNull(result, TestContext.TestName);
        }

        [TestMethod]
        public void Controller_Skills_Fishing_Default_Should_Pass()
        {
            // Arrange
            SkillsController controller = new SkillsController();

            // Act
            ViewResult result = controller.Fishing() as ViewResult;

            // Assert
            Assert.IsNotNull(result, TestContext.TestName);
        }

        [TestMethod]
        public void Controller_Skills_Fletching_Default_Should_Pass()
        {
            // Arrange
            SkillsController controller = new SkillsController();

            // Act
            ViewResult result = controller.Fletching() as ViewResult;

            // Assert
            Assert.IsNotNull(result, TestContext.TestName);
        }

        [TestMethod]
        public void Controller_Skills_Herblore_Default_Should_Pass()
        {
            // Arrange
            SkillsController controller = new SkillsController();

            // Act
            ViewResult result = controller.Herblore() as ViewResult;

            // Assert
            Assert.IsNotNull(result, TestContext.TestName);
        }

        [TestMethod]
        public void Controller_Skills_Hunter_Default_Should_Pass()
        {
            // Arrange
            SkillsController controller = new SkillsController();

            // Act
            ViewResult result = controller.Hunter() as ViewResult;

            // Assert
            Assert.IsNotNull(result, TestContext.TestName);
        }

        [TestMethod]
        public void Controller_Skills_Magic_Default_Should_Pass()
        {
            // Arrange
            SkillsController controller = new SkillsController();

            // Act
            ViewResult result = controller.Magic() as ViewResult;

            // Assert
            Assert.IsNotNull(result, TestContext.TestName);
        }

        [TestMethod]
        public void Controller_Skills_Mining_Default_Should_Pass()
        {
            // Arrange
            SkillsController controller = new SkillsController();

            // Act
            ViewResult result = controller.Mining() as ViewResult;

            // Assert
            Assert.IsNotNull(result, TestContext.TestName);
        }

        [TestMethod]
        public void Controller_Skills_Prayer_Default_Should_Pass()
        {
            // Arrange
            SkillsController controller = new SkillsController();

            // Act
            ViewResult result = controller.Prayer() as ViewResult;

            // Assert
            Assert.IsNotNull(result, TestContext.TestName);
        }

        [TestMethod]
        public void Controller_Skills_Runecrafting_Default_Should_Pass()
        {
            // Arrange
            SkillsController controller = new SkillsController();

            // Act
            ViewResult result = controller.Runecrafting() as ViewResult;

            // Assert
            Assert.IsNotNull(result, TestContext.TestName);
        }

        [TestMethod]
        public void Controller_Skills_Slayer_Default_Should_Pass()
        {
            // Arrange
            SkillsController controller = new SkillsController();

            // Act
            ViewResult result = controller.Slayer() as ViewResult;

            // Assert
            Assert.IsNotNull(result, TestContext.TestName);
        }

        [TestMethod]
        public void Controller_Skills_Smithing_Default_Should_Pass()
        {
            // Arrange
            SkillsController controller = new SkillsController();

            // Act
            ViewResult result = controller.Smithing() as ViewResult;

            // Assert
            Assert.IsNotNull(result, TestContext.TestName);
        }

        [TestMethod]
        public void Controller_Skills_Thieving_Default_Should_Pass()
        {
            // Arrange
            SkillsController controller = new SkillsController();

            // Act
            ViewResult result = controller.Thieving() as ViewResult;

            // Assert
            Assert.IsNotNull(result, TestContext.TestName);
        }

        [TestMethod]
        public void Controller_Skills_Woodcutting_Default_Should_Pass()
        {
            // Arrange
            SkillsController controller = new SkillsController();

            // Act
            ViewResult result = controller.Woodcutting() as ViewResult;

            // Assert
            Assert.IsNotNull(result, TestContext.TestName);
        }
        #endregion
    }
}
