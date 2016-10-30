namespace Saobracaj.Migrations.SaobracajEntities
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDatabaseCreation2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Kazne", "DatumUnosa", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Kazne", "DatumUnosa", c => c.String());
        }
    }
}
