using GenericRepo.Entities.Concrete;

namespace GenericRepo.Repositories.Abstract
{
    public interface IStudentRepository : IRepository<Student>
    {
        Student GetByIdIncludeSchool(int id);
        IEnumerable<Student> GetAllIncludedSchool();
        List<Student> GetAllStudentsWithLesson();
    }
}
