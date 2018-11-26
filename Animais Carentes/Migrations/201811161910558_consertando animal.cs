namespace Animais_Carentes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class consertandoanimal : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AnimalModels", "especie", c => c.String(nullable: false));
            DropColumn("dbo.AnimalModels", "raça");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AnimalModels", "raça", c => c.String(nullable: false));
            DropColumn("dbo.AnimalModels", "especie");
        }
    }
}
