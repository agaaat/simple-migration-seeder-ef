using BelajarMigrationSeeder.Models;
using BelajarMigrationSeeder.Data; // ⬅️ pastikan ada baris ini
using System.Linq;

namespace BelajarMigrationSeeder.Data;

public static class DbSeeder
{
    public static void Seed(AppDbContext context)
    {
        if (!context.Users.Any())
        {
            context.Users.AddRange(
                new User { Name = "Admin", Email = "admin@example.com" },
                new User { Name = "Ghani", Email = "ghani@example.com" }
            );
            context.SaveChanges();
        }
    }
}
