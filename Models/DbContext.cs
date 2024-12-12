using Microsoft.EntityFrameworkCore;

namespace TheFinal_jacalva.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
    {

    }

    // Needed for Many-to-Many association entity
    // StudioGame entity has 2 attributes as the primary key.
    // This code tells EF Core that StudioID and GameID combine for the primary key
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<StudioGame>().HasKey(s => new {s.GameID, s.StudioID});
    }

    public DbSet<Studio> Studios {get; set;}
    public DbSet<Game> Games {get; set;}
    public DbSet<StudioGame> StudioGames {get; set;}
}