using Microsoft.EntityFrameworkCore;
using Lab05.Models;

namespace Lab05.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        public DbSet<Learner> Learners { get; set; }
        public DbSet<Major> Majors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Major>().ToTable("Major");
            modelBuilder.Entity<Learner>().ToTable("Learner");
        }
    }
}