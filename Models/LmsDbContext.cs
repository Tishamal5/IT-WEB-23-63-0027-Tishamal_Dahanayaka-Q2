using Microsoft.EntityFrameworkCore;

namespace LMS.Models
{
    public class LmsDbContext : DbContext
    {
        public LmsDbContext(DbContextOptions<LmsDbContext> options) : base(options)
        {
        }


        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
               .HasOne(i => i.Course)
               .WithMany(p => p.Students)
               .HasForeignKey(i => i.CourseId);
        }
    }
}
