using Business.Abstract;
using Entity.Concrete;
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
        public class CarsController : ControllerBase
        {
            private ICarService _carService;

            public CarsController(ICarService carService)
            {
                _carService = carService;
            }


            [HttpGet("getall")]
            public IActionResult GetAll()
            {
                var result = _carService.GetAll();
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }

            [HttpGet("getbyid")]
            public IActionResult GetById(int id)
            {
                var result = _carService.GetCarsByBrandId(id);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }

          
            [HttpPost("add")]
            public IActionResult Add(Car car)
            {
                var result = _carService.Add(car);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }

          

            [HttpGet("getcardetailsbybrandid")]
            public IActionResult GetCarDetailsByBrandId(int id)
            {
                var result = _carService.GetCarsByBrandId(id);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }

            [HttpGet("getcardetailsbycolorid")]
            public IActionResult GetCarDetailsByColorId(int id)
            {
                var result = _carService.GetCarsByColorId(id);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }

            [HttpGet("getbybrandid")]
            public IActionResult GetByBrandId(int id)
            {
                var result = _carService.GetCarsByBrandId(id);
                if (result.Success == true)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest(result);
                }
            }

            [HttpGet("getbycolorid")]
            public IActionResult GetByColorId(int colorId)
            {
                var result = _carService.GetCarsByColorId(colorId);
                if (result.Success == true)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest(result);
                }
            }

        }
    }

