using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Saobracaj.Models;

namespace Saobracaj
{
   
    /// <summary>
    /// Summary description for kazne
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class kazne : System.Web.Services.WebService {
        private SaobracajEntities db = new SaobracajEntities();

       
        [WebMethod]
        public List<Vozilo> getVozila()
        {
            List<Vozilo> vozila = db.Vozila.ToList();
            return vozila;
        }
        [WebMethod]
     
        public List<Kazna> getKazne()
        {
            List<Kazna> kazne = db.Kazne.ToList();
            return kazne;
        }
        [WebMethod]
        public List<Problem> getProblemi()
        {
            List<Problem> problem = db.Problemi.ToList();
            return problem;
            //return problem;
        }
        [WebMethod]
        public List<Kazna> getKaznePoJMBG(string jmbg)
        {
            List<Kazna> kazne = db.Kazne.Where(a => a.naLice.JMBG == jmbg).ToList();
            return kazne;
        }
        [WebMethod]
        public List<TipProblema> getTipoveProblema ()
        {
            List<TipProblema> tipovi = db.TipoviProblema.ToList();
            return tipovi;
        }

    }
}
