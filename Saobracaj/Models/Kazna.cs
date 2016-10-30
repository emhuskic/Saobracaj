using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Saobracaj.Models
{
    public class Kazna
    {
        public int KaznaId { get; set; }
        public int VlasnikId { get; set; }
        public int VoziloId { get; set; }
        public double Iznos { get; set; }
        public string Opis { get; set; }
        public DateTime Datum { get; set; }
        public virtual Vlasnik naLice { get; set; }
        public virtual Vozilo naVozilo { get; set; }
        public string OdgovornaOsoba { get; set; }
      
    }
}