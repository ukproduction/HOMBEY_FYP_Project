using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hombay.Models;


namespace Hombay.Controllers { 

    public class AccountController: Controller
    {
        
        public ActionResult Home()
        {
            
            return View("~/Views/Account/Home.cshtml");
        }
        public ActionResult SignUp()
        {
            return View("~/Views/Account/SignUp.cshtml");
        }
        public ActionResult Login()
        {
            return View("~/Views/Account/Login.cshtml");
        }
        public ActionResult About()
        {
            return View("~/Views/Account/About.cshtml");
        }
        public ActionResult Gallery()
        {
            return View("~/Views/Account/Gallery.cshtml");
        }

    }
}