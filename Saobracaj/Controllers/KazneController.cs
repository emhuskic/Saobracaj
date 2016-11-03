using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Saobracaj.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Saobracaj.Controllers
{
    [Authorize(Roles = "Admin")]
    public class KazneController : Controller
    {
        static ApplicationDbContext context = new ApplicationDbContext();
        UserManager<ApplicationUser> UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

        private SaobracajEntities db = new SaobracajEntities();

        // GET: Kazne
        [AllowAnonymous]
        public ActionResult Index(string jmbg)
        {
            if (isAdminUser())
            {
                var kazne = db.Kazne.ToList();
                return View(kazne);
            }
            else
            {
                var kazne = db.Kazne.Include(k => k.naLice).Include(k => k.naVozilo).Where(a => a.naLice.JMBG == jmbg);
                return View(kazne);
            }
            return View();
        }
        public bool isAdminUser()
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = User.Identity;
                var s = UserManager.GetRoles(user.GetUserId());
                if (s.Count > 0 && s[0].ToString() == "Admin")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
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
                kazna.OdgovornaOsoba = this.User.Identity.Name;
               // kazna.DatumUnosa = DateTime.Now.ToString();
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
