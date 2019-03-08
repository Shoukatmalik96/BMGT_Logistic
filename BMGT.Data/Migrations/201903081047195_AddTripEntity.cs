namespace BMGT.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTripEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Trips",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LoadingDate = c.DateTime(nullable: false),
                        Fare = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FreightDescription = c.String(),
                        Weight = c.Int(nullable: false),
                        ReturnLoading = c.DateTime(nullable: false),
                        RetunFare = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Broker = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Trips");
        }
    }
}
