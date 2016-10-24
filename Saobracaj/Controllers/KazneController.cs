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
    public class KazneController : Controller
    {
        private SaobracajEntities db = new SaobracajEntities();

        // GET: Kazne
        public ActionResult Index(string jmbg)
        {
            var kazne = db.Kazne.Include(k => k.naLice).Include(k => k.naVozilo).Where(a => a.naLice.JMBG==jmbg) ;
            return View(kazne);
        }

        // GET: Kazne/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kazna kazna = db.Kazne.Find(id);
            if (kazna == null)
            {
                return HttpNotFound();
            }
            return View(kazna);
        }

        // GET: Kazne/Create
        public ActionResult Create()
        {
            ViewBag.VlasnikId = new SelectList(db.Vlasnici, "VlasnikId", "JMBG");
            ViewBag.VoziloId = new SelectList(db.Vozila, "VoziloId", "BrojTablice");
            return View();
        }

        // POST: Kazne/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "KaznaId,VlasnikId,VoziloId,Iznos,Opis,Datum")] Kazna kazna)
        {
            if (ModelState.IsValid)
            {
                db.Kazne.Add(kazna);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.VlasnikId = new SelectList(db.Vlasnici, "VlasnikId", "JMBG", kazna.VlasnikId);
            ViewBag.VoziloId = new SelectList(db.Vozila, "VoziloId", "BrojTablice", kazna.VoziloId);
            return View(kazna);
        }

        // GET: Kazne/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kazna kazna = db.Kazne.Find(id);
            if (kazna == null)
            {
                return HttpNotFound();
            }
            ViewBag.VlasnikId = new SelectList(db.Vlasnici, "VlasnikId", "JMBG", kazna.VlasnikId);
            ViewBag.VoziloId = new SelectList(db.Vozila, "VoziloId", "BrojTablice", kazna.VoziloId);
            return View(kazna);
        }

        // POST: Kazne/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "KaznaId,VlasnikId,VoziloId,Iznos,Opis,Datum")] Kazna kazna)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kazna).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.VlasnikId = new SelectList(db.Vlasnici, "VlasnikId", "JMBG", kazna.VlasnikId);
            ViewBag.VoziloId = new SelectList(db.Vozila, "VoziloId", "BrojTablice", kazna.VoziloId);
            return View(kazna);
        }

        // GET: Kazne/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kazna kazna = db.Kazne.Find(id);
            if (kazna == null)
            {
                return HttpNotFound();
            }
            return View(kazna);
        }

        // POST: Kazne/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Kazna kazna = db.Kazne.Find(id);
            db.Kazne.Remove(kazna);
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
