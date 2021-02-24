using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        IBrandService _brandDervice;

        public BrandsController(IBrandService brandDervice)
        {
            _brandDervice = brandDervice;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _brandDervice.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("get")]
        public IActionResult Get(Expression<Func<Brand, bool>> filter)
        {
            var result = _brandDervice.Get(filter);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbrandbyid")]
        public IActionResult Get(int id)
        {
            var result = _brandDervice.GetBrandById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("addbrand")]
        public IActionResult AddBrand(Brand brand)
        {
            var result = _brandDervice.Add(brand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
