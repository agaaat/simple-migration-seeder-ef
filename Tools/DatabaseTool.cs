using BelajarMigrationSeeder.Data;
using Microsoft.EntityFrameworkCore;

namespace BelajarMigrationSeeder.Tools;

public static class DatabaseTool
{
    public static void Refresh(AppDbContext db)
    {
        Console.WriteLine("🧨 Deleting database...");
        db.Database.EnsureDeleted();

        Console.WriteLine("⚙️ Applying migrations...");
        db.Database.Migrate();

        Console.WriteLine("🌱 Seeding data...");
        DbSeeder.Seed(db);

        Console.WriteLine("✅ Done! Database recreated and seeded.");
    }
}
