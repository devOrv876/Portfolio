using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    public class ProjectsController : Controller
    {
        // GET: Work
        public ActionResult Project()
        {
            ViewBag.Message = "My Work";
            return View();
        }
    }
}