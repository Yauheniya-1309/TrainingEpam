using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task14.Controllers
{
    public class DreamController : Controller
    {
        // GET: Dream
        public ActionResult Index()
        {
            ViewBag.Message = "Мечта";

            return View();
        }
    }
}