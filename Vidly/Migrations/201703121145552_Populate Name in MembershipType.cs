namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateNameinMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE dbo.MembershipTypes Set Name='Pay as You Go' WHERE Id=1");
            Sql("UPDATE dbo.MembershipTypes Set Name='Monthly' WHERE Id=2");
            Sql("UPDATE dbo.MembershipTypes Set Name='3 Months' WHERE Id=3");
            Sql("UPDATE dbo.MembershipTypes Set Name='Yearly' WHERE Id=4");

        }
        
        public override void Down()
        {
        }
    }
}
