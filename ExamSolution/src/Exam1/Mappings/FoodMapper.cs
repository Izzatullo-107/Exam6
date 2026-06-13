using Exam1.Dtos;
using Exam1.Entities;

namespace Exam1.Mappings
{
    public class FoodMapper : IFoodMapper
    {
        public Food ToEntity(FoodCreateDto dto)
        {
            return new Food
            {
                Name = dto.Name,
                Description = dto.Description,
                Price = dto.Price,
                IsAvailable = dto.IsAvailable,
                CategoryId = dto.CategoryId
            };
        }

        public Food ToEntity(FoodUpdateDto dto, Food food)
        {
            food.Name = dto.Name;
            food.Description = dto.Description;
            food.Price = dto.Price;
            food.IsAvailable = dto.IsAvailable;
            food.CategoryId = dto.CategoryId;

            return food;
        }

        public FoodGetDto ToGetDto(Food food)
        {
            return new FoodGetDto
            {
                FoodId = food.FoodId,
                Name = food.Name,
                Description = food.Description,
                Price = food.Price,
                IsAvailable = food.IsAvailable,
                CategoryId = food.CategoryId
            };
        }

        public List<FoodGetDto> ToGetDto(List<Food> foods)
        {
            return foods.Select(ToGetDto).ToList();
        }
    }
}
