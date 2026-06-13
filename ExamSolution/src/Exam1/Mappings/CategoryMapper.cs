using Exam1.Dtos;
using Exam1.Entities;

namespace Exam1.Mappings
{
    public class CategoryMapper : ICategoryMapper
    {
        public Category ToEntity(CategoryCreateDto dto)
        {
            return new Category
            {
                Name = dto.Name
            };
        }

        public Category ToEntity(CategoryUpdateDto dto, Category category)
        {
            category.Name = dto.Name;

            return category;
        }

        public CategoryGetDto ToGetDto(Category category)
        {
            return new CategoryGetDto
            {
                CategoryId = category.CategoryId,
                Name = category.Name
            };
        }

        public List<CategoryGetDto> ToGetDto(List<Category> categories)
        {
            return categories.Select(ToGetDto).ToList();
        }
    }
}
