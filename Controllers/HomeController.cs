using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;
using PracticeWebApp.Models;

namespace PracticeWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UserData()
        {
            ViewBag.Message = "Enter User Data";

            return View();
        }

        public ActionResult Submit(UserDataModels obj)
        {

            Session["ListName"] += obj.Name;
            return View(obj);
        }

    }
}