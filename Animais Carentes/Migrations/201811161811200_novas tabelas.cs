namespace Animais_Carentes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class novastabelas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AnimalModels",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ong_cnpj = c.String(maxLength: 11),
                        usuario_cpf = c.String(maxLength: 11),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.OngModels", t => t.ong_cnpj)
                .ForeignKey("dbo.UsuarioModels", t => t.usuario_cpf)
                .Index(t => t.ong_cnpj)
                .Index(t => t.usuario_cpf);
            
            CreateTable(
                "dbo.SocioModels",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        raça = c.String(nullable: false),
                        raca = c.String(),
                        descricao = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AnimalModels", "usuario_cpf", "dbo.UsuarioModels");
            DropForeignKey("dbo.AnimalModels", "ong_cnpj", "dbo.OngModels");
            DropIndex("dbo.AnimalModels", new[] { "usuario_cpf" });
            DropIndex("dbo.AnimalModels", new[] { "ong_cnpj" });
            DropTable("dbo.SocioModels");
            DropTable("dbo.AnimalModels");
        }
    }
}
