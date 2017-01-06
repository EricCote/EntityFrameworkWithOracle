namespace App3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameMimeType : DbMigration
    {
        public override void Up()
        {
            this.RenameColumn("HR.Documents", "MimeTypes", "MimeType");

        }
        
        public override void Down()
        {
            this.RenameColumn("HR.Documents", "MimeType", "MimeTypes");
        }
    }
}
