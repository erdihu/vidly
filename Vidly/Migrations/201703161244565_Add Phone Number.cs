namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPhoneNumber : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Phone", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Phone");
        }
    }
}
