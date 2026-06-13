namespace Exam1.Repositories
{
    public interface IBaseRepository<T>
    {
        Task AddAsync(T t);
        void Update(T t);
        void Delete(T t);
        Task SaveChangesAsync();
    }
}
