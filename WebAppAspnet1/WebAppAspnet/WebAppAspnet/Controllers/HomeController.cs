using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppAspnet.Models;

namespace WebAppAspnet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(UserDataStore.Instance.GetAllUsers().OrderBy(x => x.adTitle));
        }

        public ActionResult Details(int id)
        {
            return View(UserDataStore.Instance.GetUserByUserId(id));
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}