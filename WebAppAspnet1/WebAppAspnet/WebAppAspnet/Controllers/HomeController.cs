using System.Collections.Generic;
using System.Linq;
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
        //[HttpPost]
        public ActionResult Details(int? id)
        {
            Table_Company company = new Table_Company();
            List<Table_Company> modelcomp = db.Table_Company.Include(p => p.Table_Ads).ToList();
            foreach (Table_Company ta in modelcomp)
            {
                foreach (Table_Ads tr in ta.Table_Ads)
                {
                    if (id == tr.id_Ad)
                    {
                        company = ta;
                        break;
                    }
                }
            }
            return View("Details", company);
        }

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

        public PartialViewResult GetAds(string filter = null, string cmbox = null)
        {
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

        public ActionResult Contact()
        {
            ViewBag.Message = "ООО ТРИ БОГАТЫРЯ";
            return View();
        }
    }
}