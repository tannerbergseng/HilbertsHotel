namespace HilbertsHotel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class creditcard : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservations", "CreditCard", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reservations", "CreditCard");
        }
    }
}
