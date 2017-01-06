namespace App3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "HR.Contacts",
                c => new
                    {
                        ContactID = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Nom = c.String(maxLength: 50),
                        Courriel = c.String(),
                    })
                .PrimaryKey(t => t.ContactID);
            
            CreateTable(
                "HR.Documents",
                c => new
                    {
                        DocumentId = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Attachment = c.Binary(),
                        MimeTypes = c.String(),
                    })
                .PrimaryKey(t => t.DocumentId);
            
        }
        
        public override void Down()
        {
            DropTable("HR.Documents");
            DropTable("HR.Contacts");
        }
    }
}
