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
    [Authorize(Roles = "Admin")]
    public class ProblemiController : Controller
    {
        private SaobracajEntities db = new SaobracajEntities();

        // GET: Problemi
        public ActionResult Index()
        {
            var problemi = db.Problemi.Include(p => p.TipProblema);
            return View(problemi.ToList());
        }

        // GET: Problemi/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Problem problem = db.Problemi.Find(id);
            if (problem == null)
            {
                return HttpNotFound();
            }
            return View(problem);
        }

        // GET: Problemi/Create
        [AllowAnonymous]
        public ActionResult Create()
        {
            ViewBag.TipProblemaId = new SelectList(db.TipoviProblema, "TipProblemaId", "Opis");
            return View();
        }

        // POST: Problemi/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProblemId,TipProblemaId,Langitude,Lattitude,ImagePath,Vrijeme,Opis,Aktivan")] Problem problem)
        {
            if (ModelState.IsValid)
            {
                db.Problemi.Add(problem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TipProblemaId = new SelectList(db.TipoviProblema, "TipProblemaId", "Opis", problem.TipProblemaId);
            return View(problem);
        }

        // GET: Problemi/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Problem problem = db.Problemi.Find(id);
            if (problem == null)
            {
                return HttpNotFound();
            }
            ViewBag.TipProblemaId = new SelectList(db.TipoviProblema, "TipProblemaId", "Opis", problem.TipProblemaId);
            return View(problem);
        }

        // POST: Problemi/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProblemId,TipProblemaId,Langitude,Lattitude,ImagePath,Vrijeme,Opis,Aktivan")] Problem problem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(problem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TipProblemaId = new SelectList(db.TipoviProblema, "TipProblemaId", "Opis", problem.TipProblemaId);
            return View(problem);
        }

        // GET: Problemi/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Problem problem = db.Problemi.Find(id);
            if (problem == null)
            {
                return HttpNotFound();
            }
            return View(problem);
        }

        // POST: Problemi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Problem problem = db.Problemi.Find(id);
            db.Problemi.Remove(problem);
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
