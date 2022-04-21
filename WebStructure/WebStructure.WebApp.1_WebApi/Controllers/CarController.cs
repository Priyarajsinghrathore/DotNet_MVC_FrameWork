using Microsoft.AspNetCore.Mvc;
using WebStructure.Common.Models;
using WebStructure.WebApp._2_Services.ServiceInterface;

namespace WebStructure.WebApp._1_WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/SearchCar")]

    public class CarController : Controller
    {
        private ICars icar;
        public CarController(ICars _icars)
        {
            icar = _icars;
        }



        [HttpGet]
        [ProducesResponseType(200, Type = typeof(List<CarModel>))]
        public async Task<IActionResult> Get(CarSearchingParameter carSearchingParameter)
        {
            var cars = await this.icar.SearchCarsAsync(carSearchingParameter);

            if (cars == null || !cars.Any())
            {
                return NotFound();
            }

            return Json(cars);
        }


        [HttpPost]
        [ProducesResponseType(200,Type =typeof(CarModel))]
        public async Task<IActionResult> Post([FromBody] CarModel carModel)
        {
            if(await icar.SaveCarSync(carModel))
            {
                return Ok();

            }
            else
            {
                return BadRequest("Unable to Save the record");
            }
        }


       [HttpDelete("delete/{Id}")]
       [ProducesResponseType(200, Type = typeof(CarModel))]
        public async Task<IActionResult> Delete(int Id)
        {
            if (await icar.DeleteCarSync(Id))
            {
                return Ok();

            }
            else
            {
                return BadRequest("Unable to delete the record");
            }
        }
        [HttpPut("{Id}")]
        [ProducesResponseType(200, Type = typeof(List<CarModel>))]
        public async Task<IActionResult> UpdateCar([FromBody] CarModel carModel, [FromRoute] int Id)
        {
            if (await icar.UpdateCarSync(carModel, Id))
            {
                return Ok();
            }
            else
            {
                return BadRequest("Wrong Input");
            }
        }
    }
}

