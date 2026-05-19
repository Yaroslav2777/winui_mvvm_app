using Microsoft.EntityFrameworkCore;
using PracticeWork8.Models;
using System.IO;

namespace PracticeWork8.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<FitnessActivity> Activities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Use a local SQLite database file named mvvmapp.db in the app local folder.
            var dbPath = Path.Combine(Directory.GetCurrentDirectory(), "mvvmapp.db");
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }
    }
}