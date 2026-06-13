using Exam1.Dtos;

namespace Exam1.Services;

public interface IFoodService
{
    Task<IEnumerable<FoodGetDto>> GetAllAsync();
   
    Task CreateAsync(FoodCreateDto dto);
   
}
