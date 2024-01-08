using GenericRepo.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace GenericRepo.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<School> Schools { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Lesson> Lessons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<StudentLesson>().HasKey(sl => new { sl.StudentId, sl.LessonId });
            modelBuilder.Entity<StudentLesson>().HasOne(sl => sl.Lesson).WithMany(s => s.StudentLessons).HasForeignKey(s => s.LessonId).OnDelete(DeleteBehavior.ClientCascade);
            modelBuilder.Entity<StudentLesson>().HasOne(sl => sl.Student).WithMany(s => s.StudentLessons).HasForeignKey(s => s.StudentId).OnDelete(DeleteBehavior.ClientCascade);
            
            

            modelBuilder.Entity<School>().HasData(
                new School()
                {
                    Id = 1,
                    Name = "Bilgi",
                    Address = "Alibeyköy",
                    CreationDate = DateTime.Now,
                },
                new School()
                {
                    Id = 2,
                    Name = "KHAS",
                    Address = "Fatih",
                    CreationDate = DateTime.Now,
                }
                );

            modelBuilder.Entity<Student>().HasData(
                new Student()
                {
                    Id = 1,
                    ClassName = "EEEN",
                    Name = "Bg",
                    CreationDate = DateTime.Now,
                    SchoolId = 1
                },
                new Student()
                {
                    Id = 2,
                    ClassName = "EEEN",
                    Name = "OÜ",
                    CreationDate = DateTime.Now,
                    SchoolId = 1
                },
                new Student()
                {
                    Id = 3,
                    ClassName = "CMPE",
                    Name = "AÖY",
                    CreationDate = DateTime.Now,
                    SchoolId = 2
                },
                new Student()
                {
                    Id = 4,
                    ClassName = "CMPE",
                    Name = "TY",
                    CreationDate = DateTime.Now,
                    SchoolId = 2
                }

                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
