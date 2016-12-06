using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models;
using System.Web.Mvc;

namespace WebApplication1.Controllers.Tests
{
    [TestClass()]
    public class ManageControllerTests
    {
        [TestMethod()]
        public void DeleteTest()
        {
            ManageController testcontroller = new ManageController();
            DeleteViewModel model = new DeleteViewModel()
            {

            };

            var result = testcontroller.Delete(model) as Task<ActionResult>;

            Assert.AreEqual(403, result);

        }
    }
}