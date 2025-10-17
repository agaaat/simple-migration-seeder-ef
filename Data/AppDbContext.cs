using BelajarMigrationSeeder.Models;
using Microsoft.EntityFrameworkCore;

namespace BelajarMigrationSeeder.Data;  // Pastikan namespace-nya sama persis!

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<User> Users => Set<User>();
}
