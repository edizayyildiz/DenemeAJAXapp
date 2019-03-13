namespace DenemeAJAXapp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SomeChange : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.FeedBacks", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.FeedBacks", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.FeedBacks", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.FeedBacks", "Phone", c => c.String(nullable: false));
            AlterColumn("dbo.FeedBacks", "City", c => c.String(nullable: false));
            AlterColumn("dbo.FeedBacks", "Message", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.FeedBacks", "Message", c => c.String());
            AlterColumn("dbo.FeedBacks", "City", c => c.String());
            AlterColumn("dbo.FeedBacks", "Phone", c => c.String());
            AlterColumn("dbo.FeedBacks", "Email", c => c.String());
            AlterColumn("dbo.FeedBacks", "LastName", c => c.String());
            AlterColumn("dbo.FeedBacks", "FirstName", c => c.String());
        }
    }
}
