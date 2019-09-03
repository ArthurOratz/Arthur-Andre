namespace Desafio_Agenda.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class contatos : DbMigration
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Contatoes");
            DropTable("dbo.Compromissoes");
        }
    }
}
