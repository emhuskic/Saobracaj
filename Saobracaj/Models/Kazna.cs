using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Web;

namespace Saobracaj.Models
{
    [System.Xml.Serialization.XmlInclude(typeof(Vozilo))]
    [System.Xml.Serialization.XmlInclude(typeof(Vlasnik))]
    [Serializable]
    public class Kazna : ISerializable
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

        [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("KaznaId", this.KaznaId);
            info.AddValue("Iznos", this.Iznos);
            info.AddValue("Datum", this.Datum);
            info.AddValue("Vlasnik", this.naLice, typeof(Vlasnik));
            info.AddValue("Vozilo", this.naVozilo, typeof(Vozilo));

        }
    }
}