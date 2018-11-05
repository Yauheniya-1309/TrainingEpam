using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task14.Controllers
{
    public class FishController : Controller
    {
        // GET: Fish
        public ActionResult Index()
        {
            ViewBag.Message = "Рыбки";
            return View();
        }
    }
}