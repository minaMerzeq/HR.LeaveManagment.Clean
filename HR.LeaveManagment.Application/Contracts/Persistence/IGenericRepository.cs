// contracts states what you want to do by using interfaces not how you want to do it which is the implementation
// persistence refers to data access

namespace HR.LeaveManagment.Application.Contracts.Persistence;

// there r many opinions on using IGenericRepository or not since EF core dataContext operates as repository / UnitOfWork
public interface IGenericRepository<T> where T : class
{
    Task<T> GetAsync();
    Task<T> GetByIdAsync(int id);
    Task<T> CreateAsync(T entity);
    Task<T> UpdateAsync(T entity);
    Task<T> DeleteAsync(T entity);
}