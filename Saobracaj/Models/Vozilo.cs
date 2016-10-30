using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Saobracaj.Models
{
    public class Vozilo
    {
        public int VoziloId { get; set; }
        public string BrojTablice { get; set; }
        public string BrojSasije { get; set; }

        public string OdgovornaOsoba { get; set; }
        public string DatumUnosa { get; set; }
    }
}