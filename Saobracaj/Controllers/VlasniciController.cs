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
    public class VlasniciController : Controller
    {
        private SaobracajEntities db = new SaobracajEntities();

        // GET: Vlasnici
        public ActionResult Index()
        {
            return View(db.Vlasnici.ToList());
        }

        // GET: Vlasnici/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vlasnik vlasnik = db.Vlasnici.Find(id);
            if (vlasnik == null)
            {
                return HttpNotFound();
            }
            return View(vlasnik);
        }

        // GET: Vlasnici/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Vlasnici/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VlasnikId,JMBG,Ime,Prezime")] Vlasnik vlasnik)
        {
            if (ModelState.IsValid)
            {
                db.Vlasnici.Add(vlasnik);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vlasnik);
        }

        // GET: Vlasnici/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vlasnik vlasnik = db.Vlasnici.Find(id);
            if (vlasnik == null)
            {
                return HttpNotFound();
            }
            return View(vlasnik);
        }

        // POST: Vlasnici/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VlasnikId,JMBG,Ime,Prezime")] Vlasnik vlasnik)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vlasnik).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vlasnik);
        }

        // GET: Vlasnici/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vlasnik vlasnik = db.Vlasnici.Find(id);
            if (vlasnik == null)
            {
                return HttpNotFound();
            }
            return View(vlasnik);
        }

        // POST: Vlasnici/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Vlasnik vlasnik = db.Vlasnici.Find(id);
            db.Vlasnici.Remove(vlasnik);
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
