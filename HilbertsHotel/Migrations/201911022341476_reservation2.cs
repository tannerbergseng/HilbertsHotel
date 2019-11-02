namespace HilbertsHotel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reservation2 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Reservations");
            AlterColumn("dbo.Reservations", "ID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Reservations", "ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Reservations");
            AlterColumn("dbo.Reservations", "ID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Reservations", "ID");
        }
    }
}
