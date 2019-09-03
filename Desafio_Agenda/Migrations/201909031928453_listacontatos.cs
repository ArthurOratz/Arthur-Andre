namespace Desafio_Agenda.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class listacontatos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContatoCompromissoes",
                c => new
                    {
                        Contato_ID = c.Int(nullable: false),
                        Compromisso_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Contato_ID, t.Compromisso_ID })
                .ForeignKey("dbo.Contatoes", t => t.Contato_ID, cascadeDelete: true)
                .ForeignKey("dbo.Compromissoes", t => t.Compromisso_ID, cascadeDelete: true)
                .Index(t => t.Contato_ID)
                .Index(t => t.Compromisso_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ContatoCompromissoes", "Compromisso_ID", "dbo.Compromissoes");
            DropForeignKey("dbo.ContatoCompromissoes", "Contato_ID", "dbo.Contatoes");
            DropIndex("dbo.ContatoCompromissoes", new[] { "Compromisso_ID" });
            DropIndex("dbo.ContatoCompromissoes", new[] { "Contato_ID" });
            DropTable("dbo.ContatoCompromissoes");
        }
    }
}
