using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebAppAspnet.Models;

namespace WebAppAspnet.Controllers
{
    public class Table_RubricsController : Controller
    {
        private OPRISEntities12 db = new OPRISEntities12();

        // GET: Table_Rubrics
        public ActionResult Index()
        {
            return View(db.Table_Rubrics.ToList());
        }

        // GET: Table_Rubrics/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_Rubrics table_Rubrics = db.Table_Rubrics.Find(id);
            if (table_Rubrics == null)
            {
                return HttpNotFound();
            }
            return View(table_Rubrics);
        }

        // GET: Table_Rubrics/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Table_Rubrics/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_Rubric,rubName")] Table_Rubrics table_Rubrics)
        {
            if (ModelState.IsValid)
            {
                db.Table_Rubrics.Add(table_Rubrics);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(table_Rubrics);
        }

        // GET: Table_Rubrics/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_Rubrics table_Rubrics = db.Table_Rubrics.Find(id);
            if (table_Rubrics == null)
            {
                return HttpNotFound();
            }
            return View(table_Rubrics);
        }

        // POST: Table_Rubrics/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_Rubric,rubName")] Table_Rubrics table_Rubrics)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table_Rubrics).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(table_Rubrics);
        }

        // GET: Table_Rubrics/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_Rubrics table_Rubrics = db.Table_Rubrics.Find(id);
            if (table_Rubrics == null)
            {
                return HttpNotFound();
            }
            return View(table_Rubrics);
        }

        // POST: Table_Rubrics/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Table_Rubrics table_Rubrics = db.Table_Rubrics.Find(id);
            db.Table_Rubrics.Remove(table_Rubrics);
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
