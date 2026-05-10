using Microsoft.EntityFrameworkCore;
using csci340lab8.Models;

namespace csci340lab8.Data;

public class GameContext : DbContext
{
    public GameContext(DbContextOptions<GameContext> options)
        : base(options){
    }

    public DbSet<Game> Game { get; set; } = default!;
}