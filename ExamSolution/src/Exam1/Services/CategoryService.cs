using Exam1.Dtos;
using Exam1.Repositories;
using Exam1.Entities;

namespace Exam1.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<CategoryGetDto>> GetCategoriesAsync()
        {
            var categories = await _categoryRepository.GetAllCategoriesAsync();

            // Entity modelni GetDto modelga o'giramiz (Mapping)
            return categories.Select(c => new CategoryGetDto
            {
                CategoryId = c.CategoryId,
                Name = c.Name
            });
        }

        public async Task<CategoryGetDto> CreateCategoryAsync(CategoryCreateDto dto)
        {
            var category = new Category
            {
                Name = dto.Name
            };

            var createdCategory = await _categoryRepository.CreateCategoryAsync(category);

            return new CategoryGetDto
            {
                CategoryId = createdCategory.CategoryId,
                Name = createdCategory.Name
            };
        }
    }
}
