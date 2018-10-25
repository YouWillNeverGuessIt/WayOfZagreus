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
    public class HomeControllerTests
    {
        public TestContext TestContext { get; set; }

        #region Index
        [TestMethod]
        public void Controller_Home_Index_Default_Should_Pass()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result, TestContext.TestName);
        }
        #endregion

        #region About
        [TestMethod]
        public void Controller_Home_About_Default_Should_Pass()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.IsNotNull(result, TestContext.TestName);
        }
        #endregion
    }
}
