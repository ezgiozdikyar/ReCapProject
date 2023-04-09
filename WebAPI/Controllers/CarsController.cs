using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/cars")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarService _carService;
        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet]
        public IActionResult GetAllCars()
        {
            var result = _carService.GetAll();
            if(result.Success)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = _carService.GetById(id);
            if(result.Success)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpPost()]
        public IActionResult Add(Car car)
        {
            var result = _carService.AddCar(car);
            if(result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpPut()]
        public IActionResult Update(Car car)
        {
            var result = _carService.UpdateCar(car);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpDelete]
        public IActionResult Delete(Car car)
        {
            var result = _carService.DeleteCar(car);
            if(result.Success)
                return Ok(result);
            return BadRequest(result);
        }
    }
}
