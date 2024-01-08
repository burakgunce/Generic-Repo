using GenericRepo.Context;
using GenericRepo.Entities.Concrete;
using GenericRepo.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace GenericRepo.Repositories.Concrete
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        private readonly AppDbContext dbContext;

        public StudentRepository(AppDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<Student> GetAllIncludedSchool()
        {
            return dbContext.Students.Include(a => a.School);
        }

        public List<Student> GetAllStudentsWithLesson(int id)
        {
            List<Student> students = new List<Student>();

            var result = dbContext.Students.Include(s => s.StudentLessons).ThenInclude(s => s.Lesson).ToList();
            foreach (var item in result)
            {
                var x = item.StudentLessons.FirstOrDefault(x => x.LessonId == id);
                students.Add(new Student()
                {
                    Name = x.Student.Name,
                    ClassName = x.Student.ClassName,
                    School = x.Student.School,
                    StudentLessons


                });
            }
            return result;
        }

        public Student GetByIdIncludeSchool(int id)
        {
            return dbContext.Students.Include(a => a.School).FirstOrDefault(a => a.Id == id);
        }
    }
}
