using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using WebAppAspnet.Models;

namespace WebAppAspnet.Controllers
{
    public class Table_AdsController : Controller
    {
        private OPRISEntities12 db = new OPRISEntities12();

        // GET: Table_Ads
        public ActionResult Index()
        {
            return View(db.Table_Ads.ToList());
        }

        // GET: Table_Ads/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_Ads table_Ads = db.Table_Ads.Find(id);
            if (table_Ads == null)
            {
                return HttpNotFound();
            }
            return View(table_Ads);
        }

        // GET: Table_Ads/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Table_Ads/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_Ad,adTitle,adConfirm,adDatePublic,adText,id_Rubric")] Table_Ads table_Ads)
        {
            if (ModelState.IsValid)
            {
                db.Table_Ads.Add(table_Ads);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(table_Ads);
        }

        // GET: Table_Ads/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_Ads table_Ads = db.Table_Ads.Find(id);
            if (table_Ads == null)
            {
                return HttpNotFound();
            }
            return View(table_Ads);
        }

        // POST: Table_Ads/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_Ad,adTitle,adConfirm,adDatePublic,adText,id_Rubric")] Table_Ads table_Ads)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table_Ads).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(table_Ads);
        }

        // GET: Table_Ads/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_Ads table_Ads = db.Table_Ads.Find(id);
            if (table_Ads == null)
            {
                return HttpNotFound();
            }
            return View(table_Ads);
        }

        // POST: Table_Ads/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Table_Ads table_Ads = db.Table_Ads.Find(id);
            db.Table_Ads.Remove(table_Ads);
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
