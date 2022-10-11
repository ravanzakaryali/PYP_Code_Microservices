using Microsoft.AspNetCore.Mvc;

namespace Code.Category.Api.Controllers.v1;

[Route("api/v1/[controller]")]
[ApiController]
public class CategoriesController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok(new
        {
            Message = ""
        });
    }
}
