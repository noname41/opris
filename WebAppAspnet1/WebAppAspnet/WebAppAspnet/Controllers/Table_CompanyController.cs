using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using WebAppAspnet.Models;

namespace WebAppAspnet.Controllers
{
    public class Table_CompanyController : Controller
    {
        private OPRISEntities12 db = new OPRISEntities12();

        // GET: Table_Company
        public ActionResult Index()
        {
            return View(db.Table_Company.ToList());
        }

        // GET: Table_Company/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_Company table_Company = db.Table_Company.Find(id);
            if (table_Company == null)
            {
                return HttpNotFound();
            }
            return View(table_Company);
        }

        // GET: Table_Company/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Table_Company/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_Company,companyPersonName,companyPersonSurname,companyPersonSecName,companyName,companyPackage,companyPhone,companyAdress,companySite,companyMail,companyFax,companyInfo,companyPackEndDate")] Table_Company table_Company)
        {
            if (ModelState.IsValid)
            {
                db.Table_Company.Add(table_Company);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(table_Company);
        }

        // GET: Table_Company/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_Company table_Company = db.Table_Company.Find(id);
            if (table_Company == null)
            {
                return HttpNotFound();
            }
            return View(table_Company);
        }

        // POST: Table_Company/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_Company,companyPersonName,companyPersonSurname,companyPersonSecName,companyName,companyPackage,companyPhone,companyAdress,companySite,companyMail,companyFax,companyInfo,companyPackEndDate")] Table_Company table_Company)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table_Company).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(table_Company);
        }

        // GET: Table_Company/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_Company table_Company = db.Table_Company.Find(id);
            if (table_Company == null)
            {
                return HttpNotFound();
            }
            return View(table_Company);
        }

        // POST: Table_Company/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Table_Company table_Company = db.Table_Company.Find(id);
            db.Table_Company.Remove(table_Company);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
