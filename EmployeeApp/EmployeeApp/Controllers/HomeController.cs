using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeApp.Models;

namespace EmployeeApp.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //throw new Exception();
            return View();
        }

        [AllowAnonymous]
        public ActionResult Register(RegisterViewModel model)
        {
            //if (string.IsNullOrEmpty(model.FirstName))
            //{
            //    ModelState.AddModelError("Name", "Name is required");
            //}

            return View("Index", model);
        }
    }
}