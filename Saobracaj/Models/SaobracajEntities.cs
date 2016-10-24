using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Saobracaj.Models
{
    public class SaobracajEntities:DbContext
    {
        public DbSet<Vlasnik> Vlasnici { get; set; }
        public DbSet<Vozilo> Vozila { get; set; }
        public DbSet<TipProblema> TipoviProblema { get; set; }
        public DbSet<Kazna> Kazne { get; set; }
        public DbSet<Problem> Problemi { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vlasnik>().ToTable("Vlasnici");
            modelBuilder.Entity<Vozilo>().ToTable("Vozila");
            modelBuilder.Entity<TipProblema>().ToTable("TipoviProblema");
            modelBuilder.Entity<Kazna>().ToTable("Kazne");
            modelBuilder.Entity<Problem>().ToTable("Problemi");
            base.OnModelCreating(modelBuilder);
        }

    }
}