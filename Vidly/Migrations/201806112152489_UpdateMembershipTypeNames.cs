namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipTypeNames : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MEMBERSHIPTYPES SET Name='Pay as you go' where id=1");
            Sql("UPDATE MEMBERSHIPTYPES SET Name='Monthly' where id=2");
            Sql("UPDATE MEMBERSHIPTYPES SET Name='Quarterly' where id=3");
            Sql("UPDATE MEMBERSHIPTYPES SET Name='Yearly' where id=4");
        }
        
        public override void Down()
        {
        }
    }
}
