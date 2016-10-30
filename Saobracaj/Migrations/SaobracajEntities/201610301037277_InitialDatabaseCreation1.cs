namespace Saobracaj.Migrations.SaobracajEntities
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDatabaseCreation1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kazne", "OdgovornaOsoba", c => c.String());
            AddColumn("dbo.Kazne", "DatumUnosa", c => c.String());
            AddColumn("dbo.Vlasnici", "OdgovornaOsoba", c => c.String());
            AddColumn("dbo.Vlasnici", "DatumUnosa", c => c.String());
            AddColumn("dbo.Vozila", "OdgovornaOsoba", c => c.String());
            AddColumn("dbo.Vozila", "DatumUnosa", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Vozila", "DatumUnosa");
            DropColumn("dbo.Vozila", "OdgovornaOsoba");
            DropColumn("dbo.Vlasnici", "DatumUnosa");
            DropColumn("dbo.Vlasnici", "OdgovornaOsoba");
            DropColumn("dbo.Kazne", "DatumUnosa");
            DropColumn("dbo.Kazne", "OdgovornaOsoba");
        }
    }
}
