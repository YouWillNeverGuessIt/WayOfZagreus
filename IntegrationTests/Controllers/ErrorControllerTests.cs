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
    public class ErrorControllerTests
    {
        public TestContext TestContext { get; set; }

        #region General Error
        [TestMethod]
        public void Controller_Error_General_Default_Should_Pass()
        {
            // Arrange
            ErrorController controller = new ErrorController();

            // Act
            ViewResult result = controller.General() as ViewResult;

            // Assert
            Assert.IsNotNull(result, TestContext.TestName);
        }
        #endregion

        #region Page 404 Error
        [TestMethod]
        public void Controller_Error_Page404_Default_Should_Pass()
        {
            // Arrange
            ErrorController controller = new ErrorController();

            // Act
            ViewResult result = controller.Page404() as ViewResult;

            // Assert
            Assert.IsNotNull(result, TestContext.TestName);
        }
        #endregion
    }
}
