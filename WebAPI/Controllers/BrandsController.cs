using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private IBrandService _brandServices;

        public BrandsController(IBrandService brandServices)
        {
            _brandServices = brandServices;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _brandServices.GetAll();

            return result.Success ? Ok(result) : (IActionResult)BadRequest(result);
        }
    }
}
