namespace Saobracaj.Migrations.SaobracajEntities
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDatabaseCreation4 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Kazne", "DatumUnosa");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Kazne", "DatumUnosa", c => c.DateTime(nullable: false));
        }
    }
}
