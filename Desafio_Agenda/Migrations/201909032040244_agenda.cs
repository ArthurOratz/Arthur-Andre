namespace Desafio_Agenda.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class agenda : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Compromissoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Titulo = c.String(nullable: false, maxLength: 200),
                        Local = c.String(maxLength: 500),
                        dataInicio = c.DateTime(nullable: false),
                        dataFim = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Contatoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 100),
                        Sobrenome = c.String(maxLength: 100),
                        Data = c.DateTime(nullable: false),
                        Telefone = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.ID);
            
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
            DropTable("dbo.Contatoes");
            DropTable("dbo.Compromissoes");
        }
    }
}
