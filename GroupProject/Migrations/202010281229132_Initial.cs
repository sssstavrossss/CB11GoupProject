namespace GroupProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Climate",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Photo = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PlanetClimate",
                c => new
                    {
                        PlanetID = c.Int(nullable: false),
                        ClimateID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.PlanetID, t.ClimateID })
                .ForeignKey("dbo.Climate", t => t.ClimateID, cascadeDelete: true)
                .ForeignKey("dbo.Planet", t => t.PlanetID, cascadeDelete: true)
                .Index(t => t.PlanetID)
                .Index(t => t.ClimateID);
            
            CreateTable(
                "dbo.Planet",
                c => new
                    {
                        PlanetID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Gravity = c.Int(),
                        SurfaceWater = c.Int(),
                        Url = c.String(),
                        Photo = c.String(),
                    })
                .PrimaryKey(t => t.PlanetID);
            
            CreateTable(
                "dbo.PlanetRace",
                c => new
                    {
                        PlanetID = c.Int(nullable: false),
                        RaceID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.PlanetID, t.RaceID })
                .ForeignKey("dbo.Planet", t => t.PlanetID, cascadeDelete: true)
                .ForeignKey("dbo.Race", t => t.RaceID, cascadeDelete: true)
                .Index(t => t.PlanetID)
                .Index(t => t.RaceID);
            
            CreateTable(
                "dbo.Race",
                c => new
                    {
                        RaceID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Classification = c.String(),
                        AverageHeight = c.Int(nullable: false),
                        Url = c.String(),
                        Photo = c.String(),
                    })
                .PrimaryKey(t => t.RaceID);
            
            CreateTable(
                "dbo.RaceUser",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        RaceID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserID)
                .ForeignKey("dbo.Race", t => t.RaceID, cascadeDelete: true)
                .ForeignKey("dbo.User", t => t.UserID)
                .Index(t => t.UserID)
                .Index(t => t.RaceID);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        Photo = c.String(),
                        Identification = c.String(maxLength: 10),
                        Email = c.String(nullable: false),
                        NickName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.PlanetUser",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        PlanetId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserID)
                .ForeignKey("dbo.Planet", t => t.PlanetId, cascadeDelete: true)
                .ForeignKey("dbo.User", t => t.UserID)
                .Index(t => t.UserID)
                .Index(t => t.PlanetId);
            
            CreateTable(
                "dbo.UserStatistics",
                c => new
                    {
                        UserStatisticsID = c.Int(nullable: false),
                        PlanetsVisited = c.Int(),
                        TerrainsVisited = c.Int(),
                        ClimatesVisited = c.Int(),
                    })
                .PrimaryKey(t => t.UserStatisticsID)
                .ForeignKey("dbo.User", t => t.UserStatisticsID)
                .Index(t => t.UserStatisticsID);
            
            CreateTable(
                "dbo.UserStatisticsClimate",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        PlanetID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserID, t.PlanetID })
                .ForeignKey("dbo.Climate", t => t.PlanetID, cascadeDelete: true)
                .ForeignKey("dbo.UserStatistics", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID)
                .Index(t => t.PlanetID);
            
            CreateTable(
                "dbo.UserStatisticsPlanet",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        PlanetID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserID, t.PlanetID })
                .ForeignKey("dbo.Planet", t => t.PlanetID, cascadeDelete: true)
                .ForeignKey("dbo.UserStatistics", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID)
                .Index(t => t.PlanetID);
            
            CreateTable(
                "dbo.UserStatisticsTerrain",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        PlanetID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserID, t.PlanetID })
                .ForeignKey("dbo.Terrain", t => t.PlanetID, cascadeDelete: true)
                .ForeignKey("dbo.UserStatistics", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID)
                .Index(t => t.PlanetID);
            
            CreateTable(
                "dbo.Terrain",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Photo = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PlanetTerrain",
                c => new
                    {
                        PlanetID = c.Int(nullable: false),
                        TerrainID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.PlanetID, t.TerrainID })
                .ForeignKey("dbo.Planet", t => t.PlanetID, cascadeDelete: true)
                .ForeignKey("dbo.Terrain", t => t.TerrainID, cascadeDelete: true)
                .Index(t => t.PlanetID)
                .Index(t => t.TerrainID);
            
            CreateTable(
                "dbo.PlanetDetails",
                c => new
                    {
                        PlanetID = c.Int(nullable: false),
                        RotationPeriod = c.Int(nullable: false),
                        OrbitalPeriod = c.Int(nullable: false),
                        Diameter = c.Int(nullable: false),
                        Population = c.Long(),
                    })
                .PrimaryKey(t => t.PlanetID)
                .ForeignKey("dbo.Planet", t => t.PlanetID)
                .Index(t => t.PlanetID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PlanetDetails", "PlanetID", "dbo.Planet");
            DropForeignKey("dbo.PlanetClimate", "PlanetID", "dbo.Planet");
            DropForeignKey("dbo.PlanetRace", "RaceID", "dbo.Race");
            DropForeignKey("dbo.RaceUser", "UserID", "dbo.User");
            DropForeignKey("dbo.UserStatisticsTerrain", "UserID", "dbo.UserStatistics");
            DropForeignKey("dbo.UserStatisticsTerrain", "PlanetID", "dbo.Terrain");
            DropForeignKey("dbo.PlanetTerrain", "TerrainID", "dbo.Terrain");
            DropForeignKey("dbo.PlanetTerrain", "PlanetID", "dbo.Planet");
            DropForeignKey("dbo.UserStatisticsPlanet", "UserID", "dbo.UserStatistics");
            DropForeignKey("dbo.UserStatisticsPlanet", "PlanetID", "dbo.Planet");
            DropForeignKey("dbo.UserStatisticsClimate", "UserID", "dbo.UserStatistics");
            DropForeignKey("dbo.UserStatisticsClimate", "PlanetID", "dbo.Climate");
            DropForeignKey("dbo.UserStatistics", "UserStatisticsID", "dbo.User");
            DropForeignKey("dbo.PlanetUser", "UserID", "dbo.User");
            DropForeignKey("dbo.PlanetUser", "PlanetId", "dbo.Planet");
            DropForeignKey("dbo.RaceUser", "RaceID", "dbo.Race");
            DropForeignKey("dbo.PlanetRace", "PlanetID", "dbo.Planet");
            DropForeignKey("dbo.PlanetClimate", "ClimateID", "dbo.Climate");
            DropIndex("dbo.PlanetDetails", new[] { "PlanetID" });
            DropIndex("dbo.PlanetTerrain", new[] { "TerrainID" });
            DropIndex("dbo.PlanetTerrain", new[] { "PlanetID" });
            DropIndex("dbo.UserStatisticsTerrain", new[] { "PlanetID" });
            DropIndex("dbo.UserStatisticsTerrain", new[] { "UserID" });
            DropIndex("dbo.UserStatisticsPlanet", new[] { "PlanetID" });
            DropIndex("dbo.UserStatisticsPlanet", new[] { "UserID" });
            DropIndex("dbo.UserStatisticsClimate", new[] { "PlanetID" });
            DropIndex("dbo.UserStatisticsClimate", new[] { "UserID" });
            DropIndex("dbo.UserStatistics", new[] { "UserStatisticsID" });
            DropIndex("dbo.PlanetUser", new[] { "PlanetId" });
            DropIndex("dbo.PlanetUser", new[] { "UserID" });
            DropIndex("dbo.RaceUser", new[] { "RaceID" });
            DropIndex("dbo.RaceUser", new[] { "UserID" });
            DropIndex("dbo.PlanetRace", new[] { "RaceID" });
            DropIndex("dbo.PlanetRace", new[] { "PlanetID" });
            DropIndex("dbo.PlanetClimate", new[] { "ClimateID" });
            DropIndex("dbo.PlanetClimate", new[] { "PlanetID" });
            DropTable("dbo.PlanetDetails");
            DropTable("dbo.PlanetTerrain");
            DropTable("dbo.Terrain");
            DropTable("dbo.UserStatisticsTerrain");
            DropTable("dbo.UserStatisticsPlanet");
            DropTable("dbo.UserStatisticsClimate");
            DropTable("dbo.UserStatistics");
            DropTable("dbo.PlanetUser");
            DropTable("dbo.User");
            DropTable("dbo.RaceUser");
            DropTable("dbo.Race");
            DropTable("dbo.PlanetRace");
            DropTable("dbo.Planet");
            DropTable("dbo.PlanetClimate");
            DropTable("dbo.Climate");
        }
    }
}
