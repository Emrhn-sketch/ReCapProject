using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _brandServices.GetAll();

            return result.Success ? Ok(result) : (IActionResult)BadRequest(result);
        }
    }
}
