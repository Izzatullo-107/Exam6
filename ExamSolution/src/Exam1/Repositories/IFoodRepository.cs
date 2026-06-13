using Exam1.Entities;

namespace Exam1.Repositories
{
    public interface IFoodRepository
    {
        Task<IEnumerable<Food>> GetAllFoodsAsync();
        Task<Food> CreateFoodAsync(Food food);
    }
}
