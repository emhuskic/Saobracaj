using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Saobracaj.Models
{
    public class Vlasnik
    {
        public int VlasnikId { get; set; }
        public string JMBG { get; set; }
        public string Ime { get; set; }
        public string Prezime {get; set;}
        public string OdgovornaOsoba { get; set; }
        public string DatumUnosa { get; set; }
    }
}