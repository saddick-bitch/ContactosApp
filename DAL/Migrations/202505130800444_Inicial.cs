namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContactoEtiquetas",
                c => new
                    {
                        ContactoId = c.Int(nullable: false),
                        EtiquetaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ContactoId, t.EtiquetaId })
                .ForeignKey("dbo.Contactoes", t => t.ContactoId, cascadeDelete: true)
                .ForeignKey("dbo.Etiquetas", t => t.EtiquetaId, cascadeDelete: true)
                .Index(t => t.ContactoId)
                .Index(t => t.EtiquetaId);
            
            CreateTable(
                "dbo.Contactoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Telefono = c.String(),
                        Correo = c.String(),
                        TipoContactoId = c.Int(nullable: false),
                        PaisId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pais", t => t.PaisId, cascadeDelete: true)
                .ForeignKey("dbo.TipoContactoes", t => t.TipoContactoId, cascadeDelete: true)
                .Index(t => t.TipoContactoId)
                .Index(t => t.PaisId);
            
            CreateTable(
                "dbo.Pais",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        CodigoMarcacion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TipoContactoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Etiquetas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ContactoEtiquetas", "EtiquetaId", "dbo.Etiquetas");
            DropForeignKey("dbo.Contactoes", "TipoContactoId", "dbo.TipoContactoes");
            DropForeignKey("dbo.Contactoes", "PaisId", "dbo.Pais");
            DropForeignKey("dbo.ContactoEtiquetas", "ContactoId", "dbo.Contactoes");
            DropIndex("dbo.Contactoes", new[] { "PaisId" });
            DropIndex("dbo.Contactoes", new[] { "TipoContactoId" });
            DropIndex("dbo.ContactoEtiquetas", new[] { "EtiquetaId" });
            DropIndex("dbo.ContactoEtiquetas", new[] { "ContactoId" });
            DropTable("dbo.Etiquetas");
            DropTable("dbo.TipoContactoes");
            DropTable("dbo.Pais");
            DropTable("dbo.Contactoes");
            DropTable("dbo.ContactoEtiquetas");
        }
    }
}
