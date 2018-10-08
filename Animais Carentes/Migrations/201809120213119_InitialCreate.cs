namespace Animais_Carentes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OngModels",
                c => new
                    {
                        cnpj = c.String(nullable: false, maxLength: 11),
                        nome = c.String(nullable: false),
                        cep = c.String(nullable: false, maxLength: 8),
                        estado = c.String(nullable: false, maxLength: 2),
                        codade = c.String(nullable: false),
                        bairro = c.String(),
                        rua = c.String(),
                        numero = c.String(),
                        email = c.String(nullable: false, maxLength: 50),
                        senha = c.String(nullable: false, maxLength: 11),
                    })
                .PrimaryKey(t => t.cnpj);
            
            CreateTable(
                "dbo.UsuarioModels",
                c => new
                    {
                        cpf = c.String(nullable: false, maxLength: 11),
                        nome = c.String(nullable: false),
                        sobrenome = c.String(),
                        sexo = c.String(),
                        idade = c.Int(nullable: false),
                        cep = c.String(nullable: false, maxLength: 8),
                        estado = c.String(nullable: false, maxLength: 2),
                        codade = c.String(nullable: false),
                        bairro = c.String(),
                        rua = c.String(),
                        numero = c.String(),
                        email = c.String(nullable: false, maxLength: 50),
                        senha = c.String(nullable: false, maxLength: 11),
                        nascimento = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.cpf);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UsuarioModels");
            DropTable("dbo.OngModels");
        }
    }
}
