namespace Desafio_Agenda.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class compromissos : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ContatoCompromissoes", newName: "CompromissoContatoes");
            DropPrimaryKey("dbo.CompromissoContatoes");
            AddPrimaryKey("dbo.CompromissoContatoes", new[] { "Compromisso_ID", "Contato_ID" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.CompromissoContatoes");
            AddPrimaryKey("dbo.CompromissoContatoes", new[] { "Contato_ID", "Compromisso_ID" });
            RenameTable(name: "dbo.CompromissoContatoes", newName: "ContatoCompromissoes");
        }
    }
}
