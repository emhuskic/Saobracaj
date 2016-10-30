using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Saobracaj.Models;

namespace Saobracaj.Controllers
{
    public class VozilaController : Controller
    {
        private SaobracajEntities db = new SaobracajEntities();

        // GET: Vozila
        public ActionResult Index()
        {
            return View(db.Vozila.ToList());
        }

        // GET: Vozila/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vozilo vozilo = db.Vozila.Find(id);
            if (vozilo == null)
            {
                return HttpNotFound();
            }
            return View(vozilo);
        }

        // GET: Vozila/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Vozila/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VoziloId,BrojTablice,BrojSasije")] Vozilo vozilo)
        {
            if (ModelState.IsValid)
            {
                db.Vozila.Add(vozilo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vozilo);
        }

        // GET: Vozila/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vozilo vozilo = db.Vozila.Find(id);
            if (vozilo == null)
            {
                return HttpNotFound();
            }
            return View(vozilo);
        }

        // POST: Vozila/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VoziloId,BrojTablice,BrojSasije")] Vozilo vozilo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vozilo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vozilo);
        }

        // GET: Vozila/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vozilo vozilo = db.Vozila.Find(id);
            if (vozilo == null)
            {
                return HttpNotFound();
            }
            return View(vozilo);
        }

        // POST: Vozila/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Vozilo vozilo = db.Vozila.Find(id);
            db.Vozila.Remove(vozilo);
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
