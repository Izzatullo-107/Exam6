using Exam1.Dtos;
using Exam1.Mappings;
using Exam1.Repositories;

namespace Exam1.Services;

public class FoodService : IFoodService
{
    private readonly IFoodRepository _foodRepository;
    private readonly IFoodMapper _foodMapper;

    public FoodService(IFoodRepository foodRepository, IFoodMapper foodMapper)
    {
        _foodRepository = foodRepository;
        _foodMapper = foodMapper;
    }

    public async Task<IEnumerable<FoodGetDto>> GetAllAsync()
    {
        var foods = await _foodRepository.GetAllFoodsAsync();
        return _foodMapper.ToGetDto(foods.ToList());
    }

    
    public async Task CreateAsync(FoodCreateDto dto)
    {
        var food = _foodMapper.ToEntity(dto);
        await _foodRepository.CreateFoodAsync(food);
    }

   
}