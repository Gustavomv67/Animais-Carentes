namespace Animais_Carentes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class consertandotabelas : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AnimalModels", "ong_cnpj", "dbo.OngModels");
            DropForeignKey("dbo.AnimalModels", "usuario_cpf", "dbo.UsuarioModels");
            DropIndex("dbo.AnimalModels", new[] { "ong_cnpj" });
            DropIndex("dbo.AnimalModels", new[] { "usuario_cpf" });
            AddColumn("dbo.AnimalModels", "raça", c => c.String(nullable: false));
            AddColumn("dbo.AnimalModels", "raca", c => c.String());
            AddColumn("dbo.AnimalModels", "descricao", c => c.String());
            AddColumn("dbo.SocioModels", "ong_cnpj", c => c.String(maxLength: 11));
            AddColumn("dbo.SocioModels", "usuario_cpf", c => c.String(maxLength: 11));
            CreateIndex("dbo.SocioModels", "ong_cnpj");
            CreateIndex("dbo.SocioModels", "usuario_cpf");
            AddForeignKey("dbo.SocioModels", "ong_cnpj", "dbo.OngModels", "cnpj");
            AddForeignKey("dbo.SocioModels", "usuario_cpf", "dbo.UsuarioModels", "cpf");
            DropColumn("dbo.AnimalModels", "ong_cnpj");
            DropColumn("dbo.AnimalModels", "usuario_cpf");
            DropColumn("dbo.SocioModels", "raça");
            DropColumn("dbo.SocioModels", "raca");
            DropColumn("dbo.SocioModels", "descricao");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SocioModels", "descricao", c => c.String());
            AddColumn("dbo.SocioModels", "raca", c => c.String());
            AddColumn("dbo.SocioModels", "raça", c => c.String(nullable: false));
            AddColumn("dbo.AnimalModels", "usuario_cpf", c => c.String(maxLength: 11));
            AddColumn("dbo.AnimalModels", "ong_cnpj", c => c.String(maxLength: 11));
            DropForeignKey("dbo.SocioModels", "usuario_cpf", "dbo.UsuarioModels");
            DropForeignKey("dbo.SocioModels", "ong_cnpj", "dbo.OngModels");
            DropIndex("dbo.SocioModels", new[] { "usuario_cpf" });
            DropIndex("dbo.SocioModels", new[] { "ong_cnpj" });
            DropColumn("dbo.SocioModels", "usuario_cpf");
            DropColumn("dbo.SocioModels", "ong_cnpj");
            DropColumn("dbo.AnimalModels", "descricao");
            DropColumn("dbo.AnimalModels", "raca");
            DropColumn("dbo.AnimalModels", "raça");
            CreateIndex("dbo.AnimalModels", "usuario_cpf");
            CreateIndex("dbo.AnimalModels", "ong_cnpj");
            AddForeignKey("dbo.AnimalModels", "usuario_cpf", "dbo.UsuarioModels", "cpf");
            AddForeignKey("dbo.AnimalModels", "ong_cnpj", "dbo.OngModels", "cnpj");
        }
    }
}
