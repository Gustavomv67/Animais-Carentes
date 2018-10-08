namespace Animais_Carentes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adc_telefone_ong : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OngModels", "cidade", c => c.String(nullable: false));
            AddColumn("dbo.OngModels", "telefone", c => c.String(nullable: false));
            DropColumn("dbo.OngModels", "codade");
        }
        
        public override void Down()
        {
            AddColumn("dbo.OngModels", "codade", c => c.String(nullable: false));
            DropColumn("dbo.OngModels", "telefone");
            DropColumn("dbo.OngModels", "cidade");
        }
    }
}
