using Exam1.Dtos;
using Exam1.Entities;

namespace Exam1.Mappings
{
    public interface IFoodMapper
    {
        Food ToEntity(FoodCreateDto dto);
        Food ToEntity(FoodUpdateDto dto, Food food);

        FoodGetDto ToGetDto(Food food);
        List<FoodGetDto> ToGetDto(List<Food> foods);
    }
}