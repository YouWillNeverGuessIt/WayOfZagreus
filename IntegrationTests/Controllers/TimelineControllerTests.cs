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
    public class TimelineControllerTests
    {
        public TestContext TestContext { get; set; }

        #region IndexRegion
        [TestMethod]
        public void Controller_Home_Index_Default_Should_Pass()
        {
            // Arrange
            TimelineController controller = new TimelineController();

            var test = controller.Index();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result, TestContext.TestName);
            Assert.IsNotNull(test, TestContext.TestName);
        }

        #endregion IndexRegion


    }
}
