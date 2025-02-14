using Microsoft.EntityFrameworkCore;
using SuperHeroApi.Models;

namespace SuperHeroApi.Data;

    public class DataContext : DbContext
    {
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    
    }
       
    public DbSet<SuperHero> SuperHeroes { get; set; }
    public DbSet<Ability> Abilities { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<SuperHero>()
            .HasMany(sh => sh.Abilities)
            .WithOne(a => a.SuperHero)
            .HasForeignKey(a => a.SuperHeroId)
            .OnDelete(DeleteBehavior.Cascade);
    }
        }




