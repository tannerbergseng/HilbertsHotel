//namespace HilbertsHotel.Migrations
//{
//    using System;
//    using System.Data.Entity.Migrations;
    
//    public partial class initial : DbMigration
//    {
//        public override void Up()
//        {
//            CreateTable(
//                "dbo.Patrons",
//                c => new
//                    {
//                        ID = c.Int(nullable: false, identity: true),
//                        Name = c.String(),
//                        DateOfBirth = c.DateTime(),
//                        Reservations_ID = c.String(maxLength: 128),
//                    })
//                .PrimaryKey(t => t.ID)
//                .ForeignKey("dbo.Reservations", t => t.Reservations_ID)
//                .Index(t => t.Reservations_ID);
            
//            CreateTable(
//                "dbo.Reservations",
//                c => new
//                    {
//                        ID = c.String(nullable: false, maxLength: 128),
//                        CheckInId = c.Int(nullable: false),
//                        CheckIn = c.DateTime(nullable: false),
//                        Checkout = c.DateTime(nullable: false),
//                    })
//                .PrimaryKey(t => t.ID);
            
//        }
        
//        public override void Down()
//        {
//            DropForeignKey("dbo.Patrons", "Reservations_ID", "dbo.Reservations");
//            DropIndex("dbo.Patrons", new[] { "Reservations_ID" });
//            DropTable("dbo.Reservations");
//            DropTable("dbo.Patrons");
//        }
//    }
//}
