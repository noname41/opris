using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppAspnet.Models;
using static WebAppAspnet.Database.Class1;

namespace WebAppAspnet.Controllers
{
    public class HomeController : Controller
    {

        //CompanyContext db = new CompanyContext();

        //public ActionResult Index()
        //{
        //    return View(db.Company);
        //}

        public ActionResult Index()
        {
            return View(UserDataStore.Instance.GetAllUsers().OrderBy(x => x.UserName));
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