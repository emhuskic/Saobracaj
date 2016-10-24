namespace Saobracaj.Migrations.SaobracajEntities
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDatabaseCreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kazne",
                c => new
                    {
                        KaznaId = c.Int(nullable: false, identity: true),
                        VlasnikId = c.Int(nullable: false),
                        VoziloId = c.Int(nullable: false),
                        Iznos = c.Double(nullable: false),
                        Opis = c.String(),
                        Datum = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.KaznaId)
                .ForeignKey("dbo.Vlasnici", t => t.VlasnikId, cascadeDelete: true)
                .ForeignKey("dbo.Vozila", t => t.VoziloId, cascadeDelete: true)
                .Index(t => t.VlasnikId)
                .Index(t => t.VoziloId);
            
            CreateTable(
                "dbo.Vlasnici",
                c => new
                    {
                        VlasnikId = c.Int(nullable: false, identity: true),
                        JMBG = c.String(),
                        Ime = c.String(),
                        Prezime = c.String(),
                    })
                .PrimaryKey(t => t.VlasnikId);
            
            CreateTable(
                "dbo.Vozila",
                c => new
                    {
                        VoziloId = c.Int(nullable: false, identity: true),
                        BrojTablice = c.String(),
                        BrojSasije = c.String(),
                    })
                .PrimaryKey(t => t.VoziloId);
            
            CreateTable(
                "dbo.Problemi",
                c => new
                    {
                        ProblemId = c.Int(nullable: false, identity: true),
                        TipProblemaId = c.Int(nullable: false),
                        Langitude = c.Double(nullable: false),
                        Lattitude = c.Double(nullable: false),
                        ImagePath = c.String(),
                        Vrijeme = c.DateTime(nullable: false),
                        Opis = c.String(),
                        Aktivan = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ProblemId)
                .ForeignKey("dbo.TipoviProblema", t => t.TipProblemaId, cascadeDelete: true)
                .Index(t => t.TipProblemaId);
            
            CreateTable(
                "dbo.TipoviProblema",
                c => new
                    {
                        TipProblemaId = c.Int(nullable: false, identity: true),
                        Opis = c.String(),
                    })
                .PrimaryKey(t => t.TipProblemaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Problemi", "TipProblemaId", "dbo.TipoviProblema");
            DropForeignKey("dbo.Kazne", "VoziloId", "dbo.Vozila");
            DropForeignKey("dbo.Kazne", "VlasnikId", "dbo.Vlasnici");
            DropIndex("dbo.Problemi", new[] { "TipProblemaId" });
            DropIndex("dbo.Kazne", new[] { "VoziloId" });
            DropIndex("dbo.Kazne", new[] { "VlasnikId" });
            DropTable("dbo.TipoviProblema");
            DropTable("dbo.Problemi");
            DropTable("dbo.Vozila");
            DropTable("dbo.Vlasnici");
            DropTable("dbo.Kazne");
        }
    }
}
