using GenericRepo.Entities.Abstract;
using System.Linq.Expressions;

namespace GenericRepo.Repositories.Abstract
{
    public interface IRepository<T> where T : BaseEntity
    {
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        T GetById(int id);
        IEnumerable<T> GetAll();
        T FirstOrDefault(Expression<Func<T, bool>> expression);
        IEnumerable<T> GetWhereList(Expression<Func<T, bool>> expression);
    }
}
