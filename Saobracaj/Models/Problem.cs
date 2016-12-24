using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Web;

namespace Saobracaj.Models
{
    [System.Xml.Serialization.XmlInclude(typeof(TipProblema))]
    [Serializable]
    public class Problem: ISerializable   
    {

        public int ProblemId { get; set; }
        public int TipProblemaId { get; set; }
        public double Langitude { get; set; }
        public double Lattitude { get; set; }
        public string ImagePath { get; set; }
        public DateTime Vrijeme { get; set; }
        public string Opis { get; set; }
        public bool Aktivan { get; set; }
        public virtual TipProblema TipProblema { get; set; }

        [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("ProblemId", this.ProblemId);
            info.AddValue("Langitude", this.Langitude);
            info.AddValue("Lattitude", this.Lattitude);
            info.AddValue("TipProblema", this.TipProblema, typeof(TipProblema));
        }
    }
}