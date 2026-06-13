using Exam1.Dtos;
using Exam1.Services;
using Microsoft.AspNetCore.Mvc;

namespace Exam1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase 
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        
        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            var result = await _categoryService.GetCategoriesAsync();
            return Ok(result);
        }

        
        [HttpPost]
        public async Task<IActionResult> CreateCategory([FromBody] CategoryCreateDto dto)
        {
            var result = await _categoryService.CreateCategoryAsync(dto);
            return Ok(result);
        }
    }
}
