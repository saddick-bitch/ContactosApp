namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pais", "Codigo", c => c.String());
            DropColumn("dbo.Pais", "CodigoMarcacion");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pais", "CodigoMarcacion", c => c.String());
            DropColumn("dbo.Pais", "Codigo");
        }
    }
}
