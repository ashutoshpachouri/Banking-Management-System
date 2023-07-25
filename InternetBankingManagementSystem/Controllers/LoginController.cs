using InternetBankingManagementSystem.Data;
using InternetBankingManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;

namespace InternetBankingManagementSystem.Controllers
{
    public class LoginController : Controller
    {
        private readonly ApplicationContext _dbContext;

        public LoginController()
        {
            _dbContext = new ApplicationContext();
        }
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserLoginModel model)
        {
            if (ModelState.IsValid)
            {
                // Perform user authentication here, comparing provided credentials with the database
                var authenticatedUser = _dbContext.userLogins.FirstOrDefault(u => u.UserID == model.UserID && u.LoginPassword == model.LoginPassword);

                if (authenticatedUser != null)
                {
                    // Set a session variable to indicate that the user is logged in
                    Session["UserID"] = model.UserID;

                    return RedirectToAction("Dashboard");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid UserID or Login Password.");
                }
            }
            else
            {

                ModelState.AddModelError("", "Invalid UserID or Login Password.");
            }
            return View(model);
        }
        public ActionResult Logout()
        {
            // Clear the session variables related to the user's login
            Session["UserID"] = null;

            return RedirectToAction("Login");
        }

        public ActionResult Dashboard()
        {
            if (Session["UserID"] != null)
            {
                // Get the UserID from the session and use it to fetch user-specific data from the database
                var userID = Session["UserID"].ToString();

                // Perform actions with user-specific data

                // Pass the user-specific data to the view to display personalized content
                ViewBag.Message = "Hello, " + userID + "!";
            }
            else
            {
                ViewBag.Message = "Welcome Guest!";
            }

            return View();
        }
        public ActionResult SessionExpired()
        {
            return View();
        }

    }
}





