using System.ComponentModel;
using Microsoft.EntityFrameworkCore;

namespace CIDM3312FinalProject1.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context = new GameDbContext(serviceProvider.GetRequiredService<DbContextOptions<GameDbContext>>()))
            {
                if (context.Games.Any())
                {
                    return;
                }

                context.Games.AddRange(
                    new Game
                    {
                        GameName = "Galaga",
                        GameGenre = "Shooter",
                        GamePrice = 20.00M,
                        Availabilities = new List<Availability> {
                            new Availability {Available = "In Stock"}
                        }
                    },
                    new Game
                    {
                        GameName = "Street Fighter",
                        GameGenre = "Fighting",
                        GamePrice = 30.00M,
                        Availabilities = new List<Availability> {
                            new Availability {Available = "Out of Stock"}
                        }
                    },
                    new Game
                    {
                        GameName = "Pac Man",
                        GameGenre = "Puzzle",
                        GamePrice = 10.00M,
                        Availabilities = new List<Availability> {
                            new Availability {Available = "In Stock"}
                        }
                    }
                );

                context.SaveChanges();
            }
        }
    }
}