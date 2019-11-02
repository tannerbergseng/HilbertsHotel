namespace HilbertsHotel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreditcardToLong : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Reservations", "CreditCard", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Reservations", "CreditCard", c => c.Int(nullable: false));
        }
    }
}
