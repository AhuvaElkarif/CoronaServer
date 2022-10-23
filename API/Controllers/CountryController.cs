using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace API.Controllers
{
    public class CountryController: ApiController
    {

        BLL.Service.CountryService service = new BLL.Service.CountryService();

        [HttpGet]
        public List<DTO.CountryDTO> GetCountries()
        {
            return service.Get();
        }

        public DTO.CountryDTO GetCountryByCountryId(int id)
        {
            return service.GetCountryByCountryId(id);
        }


        [HttpPost]
        public IHttpActionResult Post(CountryDTO country)
        {
            try
            {
                var c = service.Post(country);
                return Created("המדינה התווספה", c);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPut]
        public IHttpActionResult Put(CountryDTO country)
        {
            try
            {
                var c = service.Put(country);
                return Created("המדינה עודכנה", c);
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
                var c = service.Delete(id);
                return Ok("המדינה נמחקה");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}
