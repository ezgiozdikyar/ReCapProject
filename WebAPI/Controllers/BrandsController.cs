﻿using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/brands")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        IBrandService _brandService;
        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpGet]
        public IActionResult GetAllBrands()
        {
            var result = _brandService.GetAll();
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = _brandService.GetById(id);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpPost()]
        public IActionResult Add(Brand brand)
        {
            var result = _brandService.AddBrand(brand);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpPut()]
        public IActionResult Update(Brand brand)
        {
            var result = _brandService.UpdateBrand(brand);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpDelete]
        public IActionResult Delete(Brand brand)
        {
            var result = _brandService.DeleteBrand(brand);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
    }
}
