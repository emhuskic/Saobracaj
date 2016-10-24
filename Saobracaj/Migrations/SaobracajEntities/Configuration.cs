namespace Saobracaj.Migrations.SaobracajEntities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Saobracaj.Models;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<Saobracaj.Models.SaobracajEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\SaobracajEntities";
        }

        protected override void Seed(Saobracaj.Models.SaobracajEntities context)
        {
            var vlasnici = new List<Vlasnik>
            {
                new Vlasnik { Ime="Emina", Prezime="Huskic", JMBG="0205995129117" },
                new Vlasnik { Ime="Ivona", Prezime="Ivkovic", JMBG="1111994111111" }
            };
            vlasnici.ForEach(s => context.Vlasnici.AddOrUpdate(p => p.JMBG, s));
            context.SaveChanges();
            var vozila = new List<Vozilo>
            {
                new Vozilo {BrojSasije="ABC12345", BrojTablice="M12-M-666" },
                new Vozilo {BrojSasije="ABCd45", BrojTablice="A11-M-226" },
                new Vozilo {BrojSasije="AEEE12345", BrojTablice="M33-E-765" }
            };
            vozila.ForEach(v => context.Vozila.AddOrUpdate(p => p.BrojTablice, v));
            context.SaveChanges();

            var tipoviproblema = new List<TipProblema>
            {
                new TipProblema {Opis="Zastoj" },
                new TipProblema {Opis="Radar" },
                new TipProblema {Opis="Radovi na cestama" }
            };
            tipoviproblema.ForEach(v => context.TipoviProblema.AddOrUpdate(p => p.Opis, v));
            context.SaveChanges();

            new List<Problem>
            {
                new Problem {Aktivan=true, Langitude=3.8575231, Lattitude=18.3991981,  TipProblema = tipoviproblema.Single(g => g.Opis== "Radar"), Vrijeme=DateTime.Now},
                new Problem {Aktivan=false, Langitude=3.4, Lattitude=17.3991981, TipProblema = tipoviproblema.Single(g => g.Opis== "Zastoj"), Vrijeme=DateTime.Now}

            }.ForEach(a => context.Problemi.Add(a));

            new List<Kazna>
            {
                new Kazna {Iznos=300, Datum=DateTime.Now, Opis="Prekoracenje brzine", VlasnikId=1, VoziloId=1}
            }.ForEach(a => context.Kazne.Add(a)); ;
        }
    }
    
}
