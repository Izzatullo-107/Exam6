using Exam1.Dtos;

namespace Exam1.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryGetDto>> GetCategoriesAsync();
        Task<CategoryGetDto> CreateCategoryAsync(CategoryCreateDto dto);
    }
}
