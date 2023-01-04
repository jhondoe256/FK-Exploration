
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    public DbSet<Player> Players { get; set; }
    public DbSet<Mario> Marios { get; set; }
    public DbSet<World> Worlds { get; set; }
    public DbSet<Level> Levels { get; set; }
    public DbSet<Coin> Coins { get; set; }
    public DbSet<PowerUp> PowerUps { get; set; }
}
