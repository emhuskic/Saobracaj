using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Saobracaj.Models;
namespace Saobracaj.Controllers
{
    public class HomeController : Controller
    {
        private SaobracajEntities baza = new SaobracajEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            var problemi = this.baza.Problemi;
            return View(problemi.ToList());
        }

        public ActionResult Contact()
        {
            var kazne = this.baza.Kazne;
            return this.View(kazne.ToList());
            
        }

        public ActionResult KazneUpit(string broj)
        {
            List<Kazna> kazne = this.baza.Kazne.ToList();
            List<Kazna> kazneJMBG = kazne.Where(a => a.naLice.JMBG==broj).ToList();
            TempData["kazne"] = kazneJMBG;
            return RedirectToAction("Index", "Kazne");
        }


    }
}