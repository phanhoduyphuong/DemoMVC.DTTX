using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMvc.Controllers
{
    public class LecturerController : Controller
    {
        // GET: Lucturer
        public ActionResult Index()
        {
            ViewBag.Id = "A001";
            ViewBag.Name = "Nguyen Van A";
            ViewData["Add"] = "TpHCM";
            return View();
        }
        public ActionResult Hello()
        {
            return Content("Hello everyone!!!");
        }
        public ActionResult GoToGG()
        {
            return Redirect("https://google.com");
        }
    }
}