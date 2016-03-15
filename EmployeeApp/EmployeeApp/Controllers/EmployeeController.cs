using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Data.Objects.DataClasses;

namespace EmployeeApp.Controllers
{
    public class EmployeeController : Controller
    {
        static kms_launchEntities data = new kms_launchEntities();

        // GET: Employee
        public ActionResult Index()
        {
            List<ASP_API> lst = (from e in data.ASP_API select e).ToList<ASP_API>();
            return View(lst);
        }

        public ActionResult Details(int id)
        {
            var model = data.ASP_API.Find(id);
            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var model = data.ASP_API.Find(id);
            return View(model);
        }
    }
}