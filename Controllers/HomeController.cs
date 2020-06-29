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
        static List<ContactDataModel> PhoneBook = new List<ContactDataModel>();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ContactData()
        {
            ViewBag.Message = "Enter User Data";

            return View();
        }

        public ActionResult Submit(ContactDataModel obj)
        {
            PhoneBook.Add(obj);
            return View(PhoneBook);
        }

    }
}