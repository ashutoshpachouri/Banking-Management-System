using InternetBankingManagementSystem.Data;
using InternetBankingManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InternetBankingManagementSystem.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        private readonly ApplicationContext _dbContext;

        public RegistrationController()
        {
            _dbContext = new ApplicationContext();
        }
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(UserRegistrationModel model)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Registrations.Add(model);
                _dbContext.SaveChanges();
                return RedirectToAction("RegistrationSuccess");
            }

            return View(model);
        }

        public ActionResult RegistrationSuccess()
        {
            return View();
        }
        public ActionResult Home()
        {
            return RedirectToAction("Login");
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dbContext.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}