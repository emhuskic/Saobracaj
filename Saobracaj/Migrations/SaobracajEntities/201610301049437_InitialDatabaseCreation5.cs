namespace Saobracaj.Migrations.SaobracajEntities
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDatabaseCreation5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kazne", "DatumUnosa", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Kazne", "DatumUnosa");
        }
    }
}
