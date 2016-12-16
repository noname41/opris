using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppAspnet.Models;
using System.Data.Entity;


namespace WebAppAspnet.Controllers
{
    public class HomeController : Controller
    {
        OPRISEntities12 db = new OPRISEntities12();

        public ActionResult Index()
        {
            return View();
        }

        //public PartialViewResult All()
        //{
        //    List<Table_Ads> model = db.Table_Ads.ToList();
        //    return PartialView("_Ads", model);
        //}  
        [HttpPost] 
        public ActionResult Index1(string filter)
        {
            ViewBag.filter = filter;
            return View();
        }
        [HttpPost]
        public ActionResult Index2(string cmbox)
        {
            ViewBag.cmbox = cmbox;
            return View();
        }
        [HttpPost]
        public ActionResult PersName(string persname)
        {
            ViewBag.persname = persname;
            return View();
        }
        [HttpPost]
        public ActionResult PersSurn(string perssname)
        {
            ViewBag.perssname = perssname;
            return View();
        }
        [HttpPost]
        public ActionResult PersSecn(string persecname)
        {
            ViewBag.persecname = persecname;
            return View();
        }
        [HttpPost]
        public ActionResult CompName(string compname)
        {
            ViewBag.compname = compname;
            return View();
        }
        [HttpPost]
        public ActionResult CompPack(string comppack)
        {
            ViewBag.comppack = comppack;
            return View();
        }
        [HttpPost]
        public ActionResult CompPhone(string compphone)
        {
            ViewBag.compphone = compphone;
            return View();
        }
        [HttpPost]
        public ActionResult CompAdr(string compadr)
        {
            ViewBag.compadr = compadr;
            return View();
        }
        [HttpPost]
        public ActionResult CompSite(string compsite)
        {
            ViewBag.compsite = compsite;
            return View();
        }
        [HttpPost]
        public ActionResult CompMail(string compmail)
        {
            ViewBag.compmail = compmail;
            return View();
        }
        [HttpPost]
        public ActionResult CompFax(string compfax)
        {
            ViewBag.compfax = compfax;
            return View();
        }
        [HttpPost]
        public ActionResult CompanyInfo(string compinfo)
        {
            ViewBag.compinfo = compinfo;
            return View();
        }
        [HttpPost]
        public ActionResult CompanyPackEnd(string pckdate)
        {
            ViewBag.pckdate = pckdate;
            return View();
        }

        public ActionResult AddCompany(string persname = null, string perssname = null, string persecname = null, string compname = null, string comppack = null, string compphone = null, string compadr = null, string compsite = null, string compmail = null, string compfax = null, string compinfo = null, string pckdate = null)
        {


            return View();
        }


        public PartialViewResult GetAds(string filter = null, string cmbox = null)
        {
            //List<Table_Ads> model = db.Table_Ads
            List<Table_Ads> model = db.Table_Ads.Include(p => p.Table_Rubrics).ToList();
            List<Table_Ads> reslist = new List<Table_Ads>();
            if ((filter == null || filter == "") && (cmbox == null || cmbox == "Выберите рубрику"))
            {
                reslist = model.ToList();
            }
            else
            {
                foreach (Table_Ads ta in model)
                {
                    foreach (Table_Rubrics tr in ta.Table_Rubrics)
                    {

                        if (filter == "" && cmbox == tr.rubName)
                        {
                            var obj = ta;
                            reslist.Add(obj);
                        }
                        else
                        {
                            if (ta.adTitle.Contains(filter) == true && cmbox == "Выберите рубрику")
                            {
                                var obj = ta;
                                reslist.Add(obj);
                            }
                            else
                            {
                                if (ta.adTitle.Contains(filter) == true && cmbox == tr.rubName)
                                {
                                    var obj = ta;
                                    reslist.Add(obj);
                                }
                                else 
                                {
                                    
                                }                        
                            }
                        }
                    }
                    }
                }

            return PartialView("_tableAds", reslist);
        }

        //public ActionResult Details(int id)
        //{
        //    return View(UserDataStore.Instance.GetUserByUserId(id));
        //}

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}