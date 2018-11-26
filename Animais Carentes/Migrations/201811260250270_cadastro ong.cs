namespace Animais_Carentes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cadastroong : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OngModels", "cadastro", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.OngModels", "cadastro");
        }
    }
}
