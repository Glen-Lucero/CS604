using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers.Tests
{
    [TestClass()]
    public class AccountControllerTests
    {
        [TestMethod()]
        public void RegisterViewTest()
        {
            AccountController controllerTest = new AccountController();

            ViewResult result = controllerTest.Register() as ViewResult;
            Assert.AreEqual("Register", result.ViewName);

        }
        // Test Login View
        [TestMethod()]
        public void LoginViewTest()
        {
            AccountController controllerTest = new AccountController();

            ViewResult result = controllerTest.Login("Index") as ViewResult;

            Assert.AreEqual("", result.ViewName);
        }

        // Test the registration email confirmation stuff
        [TestMethod()]
        public void ConfirmEmailTestFailure()
        {
            AccountController controllertest = new AccountController();

            var result = controllertest.ConfirmEmail(null, null) as Task<ActionResult>;
            var view = result.Result as ViewResult;

            Assert.AreEqual(view.ViewName, "Error");

        }
        // Test Registration
        [TestMethod()]
        public void RegisterUserTest()
        {
            // Stuck HERE -----
            /**var mockModel = new { Email = "glucero45@gmail.com", Password = "123password", ConfirmPassword = "123password" };
            AccountController controllerTest = new AccountController();

            var result = controllerTest.Register(mockModel);
            **/
        }

        // Test Login
        [TestMethod()]
        public void LoginTest()
        {
            AccountController controllertest = new AccountController();

            LoginViewModel model = new LoginViewModel()
            {
                Email = "glucero44@gmail.com",
                Password = "Pa$$w0rd"
            };

            var returnUrl = "Index";

            var result = controllertest.Login(model, returnUrl) as Task<ActionResult>;

            var resultView = result.Result as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreEqual(resultView.ViewName, "Index");

        }
    }
}