using HeroesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HeroesAPI.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Hero> Heroes { get; set; }
}