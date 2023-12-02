using Microsoft.EntityFrameworkCore;

namespace CIDM3312FinalProject1.Models
{
    public class GameDbContext : DbContext
    {
        public GameDbContext (DbContextOptions<GameDbContext> options) : base(options)
        {
        }
        public DbSet<Game> Games {get;set;} = default!;
        public DbSet<Availability> Availabilities {get; set;} = default!;
        
    }
}