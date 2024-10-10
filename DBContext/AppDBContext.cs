using api_tarefa.Models;
using Microsoft.EntityFrameworkCore;

namespace api_tarefa.DBContext
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        public DbSet<User> users { get; set; }
        public DbSet<SchoolTask> schoolTasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SchoolTask>()
                .HasOne(t => t.user)
                .WithMany(u => u.schoolTasks)
                .HasForeignKey(t => t.user)
                .OnDelete(DeleteBehavior.Restrict);
            base.OnModelCreating(modelBuilder);
        }

    }
}
