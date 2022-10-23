using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace API.Controllers
{
    public class VaccineManufacturerController : ApiController
    {
        BLL.Service.VaccineManufacturerService service = new BLL.Service.VaccineManufacturerService();

        [HttpGet]
        public List<DTO.VaccineManufacturerDTO> GetVaccineManufacturers()
        {
            return service.Get();
        }

        public DTO.VaccineManufacturerDTO GetVaccineManufacturerById(int id)
        {
            return service.GetVaccineManufacturerById(id);
        }


        [HttpPost]
        public IHttpActionResult Post(VaccineManufacturerDTO v)
        {
            try
            {
                var vm = service.Post(v);
                return Created("יצרן החיסון התווסף", vm);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPut]
        public IHttpActionResult Put(VaccineManufacturerDTO v)
        {
            try
            {
                var vm = service.Put(v);
                return Created("יצרן החיסון עודכן", vm);
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
                return Ok("יצרן החיסון נמחק");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}
    