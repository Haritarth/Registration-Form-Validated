using JqueryFormValidator.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JqueryFormValidator.Controllers
{
    public class HomeController : Controller
    {
        #region Register

        //
        // GET: /Home/Register
        [AllowAnonymous]
        public ActionResult Register()
        {
            RegisterViewModel rvm = new RegisterViewModel();
            return View(rvm);
        }

        //
        // POST: /Home/Register
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Register(RegisterViewModel rvm)
        {
            TempData["Rvm"] = rvm;

            //if (ModelState.IsValid)
            //{
                // Info.
                return Redirect("/Home/ShowDetails");
            //}

            //// If we got this far, something failed, redisplay form
            //return View(rvm);
        }

        public ActionResult ShowDetails()
        {
            RegisterViewModel rvm = TempData["Rvm"] as RegisterViewModel;
            return View(rvm);
        }

        #endregion
    }
}