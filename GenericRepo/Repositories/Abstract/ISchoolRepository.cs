using GenericRepo.Entities.Concrete;

namespace GenericRepo.Repositories.Abstract
{
    public interface ISchoolRepository : IRepository<School>
    {
        IEnumerable<School> GetAllWithStudents();   
    }
}
