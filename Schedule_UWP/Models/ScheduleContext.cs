using Microsoft.Data.Entity;
using Models;

namespace Schedule_UWP.Models
{
    public class ScheduleContext : DbContext
    {
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Cathedra> Cathedries { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Lesson> Lessons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename=Blogging.db");
        }
    }
}
