using GenericRepo.Context;
using GenericRepo.Entities.Concrete;
using GenericRepo.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace GenericRepo.Repositories.Concrete
{
    public class SchoolRepository : GenericRepository<School>, ISchoolRepository
    {
        private readonly AppDbContext dbContext;

        public SchoolRepository(AppDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<School> GetAllWithStudents()
        {
            return dbContext.Schools.Include(a=>a.Students);
            
        }
    }
}
