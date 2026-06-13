using Exam1.Dtos;
using Exam1.Services;
using Microsoft.AspNetCore.Mvc;

namespace Exam1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FoodController : ControllerBase
    {
        private readonly IFoodService _foodService;

        public FoodController(IFoodService foodService)
        {
            _foodService = foodService;
        }

        
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _foodService.GetAllAsync();
            return Ok(result);
        }

       
        [HttpPost]
        public async Task<IActionResult> Create(FoodCreateDto dto)
        {
            await _foodService.CreateAsync(dto);
            return Ok("Created");
        }

        
    }
}
