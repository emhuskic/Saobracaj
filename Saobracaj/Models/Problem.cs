using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Saobracaj.Models
{
    public class Problem
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
    }
}