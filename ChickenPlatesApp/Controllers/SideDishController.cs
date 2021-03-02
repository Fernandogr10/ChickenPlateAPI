using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChickenPlatesApp.Dtos;
using ChickenPlatesApp.Models;
using ChickenPlatesApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ChickenPlatesApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SideDishController : ControllerBase
    {
        private readonly ISideDishService _sideDishService;

        public SideDishController(ISideDishService sideDishService)
        {
            _sideDishService = sideDishService;
        }

        // GET: api/<SIdeDishController>
        [HttpGet("GetAll")]
        public ActionResult<List<SideDish>> GetAll()
        {
            var result = _sideDishService.GetAll();
            return result != null ? (ActionResult) Ok(result) : NotFound();
        }

        [HttpGet("Get/{id}")]
        public ActionResult<SideDish> Get(long id)
        {
            var result = _sideDishService.Get(id);
            return result != null ? (ActionResult) Ok(result) : NotFound();
        }

        [HttpPost("Create")]
        public ActionResult<SideDish> Create([FromBody] SideDishDto sideDishObject)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var sideDish = new SideDish {DishName = sideDishObject.DishName};

                var result = _sideDishService.Create(sideDish);
                _sideDishService.SaveChanges();

                return Ok(result);
            }

            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPut("{id}")]
        public ActionResult<SideDish> Put(int id, [FromBody] SideDishDto sideDishObject)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var entity = _sideDishService.Get(id);
                if (entity is null)
                    return NotFound();

                entity = new SideDish {DishName = sideDishObject.DishName};

                var result = _sideDishService.Update(entity);
                _sideDishService.SaveChanges();

                return Ok(result);
            }

            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var entity = _sideDishService.Get(id);

            if (entity is null)
                return NotFound();

            _sideDishService.Delete(entity);
            _sideDishService.SaveChanges();

            return NoContent();
        }
    }
}