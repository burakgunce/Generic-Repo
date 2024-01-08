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

        public Student GetByIdIncludeSchool(int id)
        {
            return dbContext.Students.Include(a => a.School).FirstOrDefault(a => a.Id == id);
        }
    }
}
