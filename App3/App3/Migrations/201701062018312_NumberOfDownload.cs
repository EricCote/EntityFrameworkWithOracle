namespace App3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NumberOfDownload : DbMigration
    {
        public override void Up()
        {
            AddColumn("HR.Documents", "numberOfDownloads", c => c.Decimal(nullable: false, precision: 10, scale: 0));
        }
        
        public override void Down()
        {
            DropColumn("HR.Documents", "numberOfDownloads");
        }
    }
}
