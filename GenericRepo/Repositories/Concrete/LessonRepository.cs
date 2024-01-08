using GenericRepo.Context;
using GenericRepo.Entities.Concrete;
using GenericRepo.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace GenericRepo.Repositories.Concrete
{
    public class LessonRepository : GenericRepository<Lesson>, ILessonRepository
    {
        private readonly AppDbContext dbContext;

        public LessonRepository(AppDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Lesson> GetAllLessonsWithStudents()
        {
            return dbContext.Lessons.Include(l => l.StudentLessons).ToList();
        }
    }
}
