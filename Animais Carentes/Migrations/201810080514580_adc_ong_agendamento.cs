namespace Animais_Carentes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adc_ong_agendamento : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AgendamentoModels",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        dataEntrega = c.DateTime(nullable: false),
                        usuarioEntrega = c.Boolean(nullable: false),
                        ong_cnpj = c.String(nullable: false, maxLength: 11),
                        usuario_cpf = c.String(nullable: false, maxLength: 11),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.OngModels", t => t.ong_cnpj, cascadeDelete: true)
                .ForeignKey("dbo.UsuarioModels", t => t.usuario_cpf, cascadeDelete: true)
                .Index(t => t.ong_cnpj)
                .Index(t => t.usuario_cpf);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AgendamentoModels", "usuario_cpf", "dbo.UsuarioModels");
            DropForeignKey("dbo.AgendamentoModels", "ong_cnpj", "dbo.OngModels");
            DropIndex("dbo.AgendamentoModels", new[] { "usuario_cpf" });
            DropIndex("dbo.AgendamentoModels", new[] { "ong_cnpj" });
            DropTable("dbo.AgendamentoModels");
        }
    }
}
