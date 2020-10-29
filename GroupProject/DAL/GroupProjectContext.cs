using GroupProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace GroupProject.DAL
{
    public class GroupProjectContext: DbContext
    {
        public GroupProjectContext() : base("GroupProjectContext") { }

        public DbSet<Planet> Planets { get; set; }
        public DbSet<PlanetDetails> PlanetDetails { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Climate> Climates { get; set; }
        public DbSet<Terrain> Terrains { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserStatistics> UsersStatistics { get; set; }
        public DbSet<PlanetRace> PlanetRaces { get; set; }
        public DbSet<PlanetTerrain> PlaneTerrains { get; set; }
        public DbSet<PlanetClimate> PlanetClimates { get; set; }
        public DbSet<PlanetUser> PlanetUsers { get; set; }
        public DbSet<RaceUser> RaceUsers { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<FlightDeparture> DepartureFlights { get; set; }
        public DbSet<FlightDestination> FlightDestinations { get; set; }
        public DbSet<UserStatisticsFlight> UsersStatisticsFlights { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();


        }
    }
}