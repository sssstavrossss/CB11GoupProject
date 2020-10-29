namespace GroupProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingFlightClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FlightDeparture",
                c => new
                    {
                        FlightDepartureID = c.Int(nullable: false, identity: true),
                        PlanetID = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.FlightDepartureID)
                .ForeignKey("dbo.Planet", t => t.PlanetID, cascadeDelete: false)
                .Index(t => t.PlanetID);
            
            CreateTable(
                "dbo.Flight",
                c => new
                    {
                        FlightID = c.Int(nullable: false, identity: true),
                        FlightDepartureID = c.Int(nullable: false),
                        FlightDestinationID = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Interval = c.Int(nullable: false),
                        Distance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Time = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.FlightID)
                .ForeignKey("dbo.FlightDeparture", t => t.FlightDepartureID, cascadeDelete: true)
                .ForeignKey("dbo.FlightDestination", t => t.FlightDestinationID, cascadeDelete: true)
                .Index(t => t.FlightDepartureID)
                .Index(t => t.FlightDestinationID);
            
            CreateTable(
                "dbo.FlightDestination",
                c => new
                    {
                        FlightDestinationID = c.Int(nullable: false, identity: true),
                        PlanetID = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.FlightDestinationID)
                .ForeignKey("dbo.Planet", t => t.PlanetID, cascadeDelete: false)
                .Index(t => t.PlanetID);
            
            CreateTable(
                "dbo.UserStatisticsFlight",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        FlightID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserID, t.FlightID })
                .ForeignKey("dbo.Flight", t => t.FlightID, cascadeDelete: true)
                .ForeignKey("dbo.UserStatistics", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID)
                .Index(t => t.FlightID);
            
            AddColumn("dbo.User", "Flight_FlightID", c => c.Int());
            AddColumn("dbo.UserStatistics", "FlightsTotal", c => c.Int());
            CreateIndex("dbo.User", "Flight_FlightID");
            AddForeignKey("dbo.User", "Flight_FlightID", "dbo.Flight", "FlightID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FlightDeparture", "PlanetID", "dbo.Planet");
            DropForeignKey("dbo.User", "Flight_FlightID", "dbo.Flight");
            DropForeignKey("dbo.UserStatisticsFlight", "UserID", "dbo.UserStatistics");
            DropForeignKey("dbo.UserStatisticsFlight", "FlightID", "dbo.Flight");
            DropForeignKey("dbo.Flight", "FlightDestinationID", "dbo.FlightDestination");
            DropForeignKey("dbo.FlightDestination", "PlanetID", "dbo.Planet");
            DropForeignKey("dbo.Flight", "FlightDepartureID", "dbo.FlightDeparture");
            DropIndex("dbo.UserStatisticsFlight", new[] { "FlightID" });
            DropIndex("dbo.UserStatisticsFlight", new[] { "UserID" });
            DropIndex("dbo.User", new[] { "Flight_FlightID" });
            DropIndex("dbo.FlightDestination", new[] { "PlanetID" });
            DropIndex("dbo.Flight", new[] { "FlightDestinationID" });
            DropIndex("dbo.Flight", new[] { "FlightDepartureID" });
            DropIndex("dbo.FlightDeparture", new[] { "PlanetID" });
            DropColumn("dbo.UserStatistics", "FlightsTotal");
            DropColumn("dbo.User", "Flight_FlightID");
            DropTable("dbo.UserStatisticsFlight");
            DropTable("dbo.FlightDestination");
            DropTable("dbo.Flight");
            DropTable("dbo.FlightDeparture");
        }
    }
}
