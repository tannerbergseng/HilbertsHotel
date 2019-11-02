namespace HilbertsHotel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class useraddID : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Users");
            AddColumn("dbo.Users", "ID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Users", "FirstName", c => c.String());
            AddPrimaryKey("dbo.Users", "ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Users");
            AlterColumn("dbo.Users", "FirstName", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Users", "ID");
            AddPrimaryKey("dbo.Users", "FirstName");
        }
    }
}
