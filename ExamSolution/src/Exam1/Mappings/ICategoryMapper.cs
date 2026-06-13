using Exam1.Dtos;
using Exam1.Entities;

namespace Exam1.Mappings
{
    public interface ICategoryMapper
    {
        Category ToEntity(CategoryCreateDto dto);
        Category ToEntity(CategoryUpdateDto dto, Category category);

        CategoryGetDto ToGetDto(Category category);
        List<CategoryGetDto> ToGetDto(List<Category> categories);
    }
}