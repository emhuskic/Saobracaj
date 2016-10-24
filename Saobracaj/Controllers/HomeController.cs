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

            return View();
        }

        public ActionResult Contact()
        {
            var kazne = this.baza.Kazne;
            return this.View(kazne.ToList());
            
        }
    }
}