using GenericRepo.Entities.Concrete;

namespace GenericRepo.Repositories.Abstract
{
    public interface ILessonRepository : IRepository<Lesson>
    {
        List<Lesson> GetAllLessonsWithStudents();
    }
}
