using Microsoft.EntityFrameworkCore;
using SuperHeroApi.Models;

namespace SuperHeroApi.Data;

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<SuperHero> SuperHeros { get; set; } = null!;

        public DbSet<Villain> Villain { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SuperHero>().HasData(
                new SuperHero { id = 1, HeroName = "Spider-Man", FirstName = "Peter", LastName = "Parker", Place = "New York", Description = "A young man with spider-like abilities", Abilities = "Web-slinging, Wall-crawling, Spider sense", Health = 100, Speed = 15.0, Strength = 50, Role = "Offensive" },
                new SuperHero { id = 2, HeroName = "Iron Man", FirstName = "Tony", LastName = "Stark", Place = "New York", Description = "A billionaire inventor and superhero", Abilities = "Flight, Energy blasts, Genius intellect", Health = 200, Speed = 10.5, Strength = 75, Role = "Offensive" },
                new SuperHero { id = 3, HeroName = "Captain America", FirstName = "Steve", LastName = "Rogers", Place = "Brooklyn, New York", Description = "A super-soldier enhanced by a serum", Abilities = "Super strength, Enhanced endurance, Shield", Health = 150, Speed = 12.0, Strength = 80, Role = "Defensive" },
                new SuperHero { id = 4, HeroName = "Thor", FirstName = "Thor", LastName = "Odinson", Place = "Asgard", Description = "The God of Thunder, wielder of Mjolnir", Abilities = "Super strength, Flight, Lightning control", Health = 250, Speed = 11.0, Strength = 100, Role = "Offensive" },
                new SuperHero { id = 5, HeroName = "Black Panther", FirstName = "T'Challa", LastName = "", Place = "Wakanda", Description = "The king of Wakanda with enhanced physical abilities", Abilities = "Super strength, Agility, Vibranium suit", Health = 175, Speed = 14.0, Strength = 70, Role = "Offensive" }
            );

            modelBuilder.Entity<Villain>().HasData(
                new Villain { id = 1, VillainName = "Green Goblin", FirstName = "Norman", LastName = "Osborn", Place = "New York", Description = "A dangerous foe with high-tech weapons", Abilities = "Glider, Pumpkin bombs, Super strength", Health = 120, Speed = 10.0, Strength = 70, Role = "Offensive" },
                new Villain { id = 2, VillainName = "Thanos", FirstName = "Thanos", LastName = "", Place = "Titan", Description = "The Mad Titan with a quest for universal power", Abilities = "Super strength, Immortality, Reality manipulation", Health = 250, Speed = 8.5, Strength = 95, Role = "Offensive" },
                new Villain { id = 3, VillainName = "Loki", FirstName = "Loki", LastName = "", Place = "Asgard", Description = "The God of Mischief, brother of Thor", Abilities = "Illusion casting, Shape-shifting, Magic", Health = 150, Speed = 13.0, Strength = 50, Role = "Support" },
                new Villain { id = 4, VillainName = "Doctor Doom", FirstName = "Victor", LastName = "Von Doom", Place = "Latveria", Description = "A genius with vast technological and magical powers", Abilities = "Magic, Super intellect, Energy blasts", Health = 175, Speed = 10.0, Strength = 80, Role = "Offensive" },
                new Villain { id = 5, VillainName = "Ultron", FirstName = "Ultron", LastName = "", Place = "Unknown", Description = "A rogue AI bent on global destruction", Abilities = "Artificial intelligence, Super strength, Flight", Health = 200, Speed = 9.0, Strength = 90, Role = "Offensive" }
            );
        }
    }

