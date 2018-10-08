namespace Animais_Carentes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class melhorando_agendamento1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AgendamentoModels", "ong_cnpj", "dbo.OngModels");
            DropForeignKey("dbo.AgendamentoModels", "usuario_cpf", "dbo.UsuarioModels");
            DropIndex("dbo.AgendamentoModels", new[] { "ong_cnpj" });
            DropIndex("dbo.AgendamentoModels", new[] { "usuario_cpf" });
            AlterColumn("dbo.AgendamentoModels", "ong_cnpj", c => c.String(maxLength: 11));
            AlterColumn("dbo.AgendamentoModels", "usuario_cpf", c => c.String(maxLength: 11));
            CreateIndex("dbo.AgendamentoModels", "ong_cnpj");
            CreateIndex("dbo.AgendamentoModels", "usuario_cpf");
            AddForeignKey("dbo.AgendamentoModels", "ong_cnpj", "dbo.OngModels", "cnpj");
            AddForeignKey("dbo.AgendamentoModels", "usuario_cpf", "dbo.UsuarioModels", "cpf");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AgendamentoModels", "usuario_cpf", "dbo.UsuarioModels");
            DropForeignKey("dbo.AgendamentoModels", "ong_cnpj", "dbo.OngModels");
            DropIndex("dbo.AgendamentoModels", new[] { "usuario_cpf" });
            DropIndex("dbo.AgendamentoModels", new[] { "ong_cnpj" });
            AlterColumn("dbo.AgendamentoModels", "usuario_cpf", c => c.String(nullable: false, maxLength: 11));
            AlterColumn("dbo.AgendamentoModels", "ong_cnpj", c => c.String(nullable: false, maxLength: 11));
            CreateIndex("dbo.AgendamentoModels", "usuario_cpf");
            CreateIndex("dbo.AgendamentoModels", "ong_cnpj");
            AddForeignKey("dbo.AgendamentoModels", "usuario_cpf", "dbo.UsuarioModels", "cpf", cascadeDelete: true);
            AddForeignKey("dbo.AgendamentoModels", "ong_cnpj", "dbo.OngModels", "cnpj", cascadeDelete: true);
        }
    }
}
