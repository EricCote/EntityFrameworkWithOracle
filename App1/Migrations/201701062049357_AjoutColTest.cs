namespace App1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjoutColTest : DbMigration
    {
        public override void Up()
        {
            AddColumn("HR.EMPLOYEES", "TEST", c => c.String(maxLength: 3));
        }
        
        public override void Down()
        {
            DropColumn("HR.EMPLOYEES", "TEST");
        }
    }
}
