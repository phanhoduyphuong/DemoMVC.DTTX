using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Session["Name"] = "MVC Asp.net";
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult LoginProcess()
        {
            string user = Request.Form["username"];
            string pass = Request.Form["password"];
            if(user == "admin" && pass == "admin")
            {
                Session["User"] = user;
                return RedirectToAction("Index");
            }            
            return RedirectToAction("Login");            
        }
        public ActionResult Logout()
        {
            Session.Remove("User");
            return RedirectToAction("Login");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Post()
        {
            return View();
        }
        public ActionResult Add()
        {
            return View();
        }
    }
}