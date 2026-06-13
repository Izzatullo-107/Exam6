using Exam1.Data;
using Exam1.Entities;

namespace Exam1.Repositories
{
    public class FoodRepository
    {
        private readonly AppDbContext _context;

        public FoodRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Food>> GetAllFoodsAsync()
        {
            return await _context.Foods.Include(f => f.Category).ToListAsync();
        }

        public async Task<Food> CreateFoodAsync(Food food)
        {
            await _context.Foods.AddAsync(food);
            await _context.SaveChangesAsync();
            return food;
        }
    }
}
