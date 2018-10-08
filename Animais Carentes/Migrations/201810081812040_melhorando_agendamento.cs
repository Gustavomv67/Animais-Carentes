namespace Animais_Carentes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class melhorando_agendamento : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AgendamentoModels", "enderecoEntrega", c => c.String());
            AddColumn("dbo.AgendamentoModels", "animal", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AgendamentoModels", "animal");
            DropColumn("dbo.AgendamentoModels", "enderecoEntrega");
        }
    }
}
