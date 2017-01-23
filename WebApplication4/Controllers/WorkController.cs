using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    public class WorkController : Controller
    {
        // GET: Work
        public ActionResult Work()
        {
            ViewBag.Message = "My Work";
            return View();
        }
    }
}