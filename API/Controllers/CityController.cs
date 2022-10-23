using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace API.Controllers
{
    public class CityController : ApiController
    {
        BLL.Service.CityService service = new BLL.Service.CityService();

        [HttpGet]
        [Route("Api/city/GetCities")]
        public List<DTO.CityDTO> GetCities()
        {
            return service.Get();
        }

        public DTO.CityDTO GetCityByCityId(int id)
        {
            return service.GetcityBycityId(id);
        }


        [HttpPost]
        public IHttpActionResult Post(CityDTO city)
        {
            try
            {
                var c = service.Post(city);
                return Created("העיר התווספה", c);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPut]
        public IHttpActionResult Put(CityDTO city)
        {
            try
            {
                var c = service.Put(city);
                return Created("העיר עודכנה", c);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                var m = service.Delete(id);
                return Ok("העיר נמחקה");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}
