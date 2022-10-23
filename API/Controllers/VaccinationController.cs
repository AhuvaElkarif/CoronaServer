using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace API.Controllers
{
    public class VaccinationController : ApiController
    {

        BLL.Service.VaccinationService service = new BLL.Service.VaccinationService();
        [HttpGet]
        public List<DTO.VaccinationDTO> GetVaccinations()
        {
            return service.Get();
        }

        public List<DTO.VaccinationDTO> GetVaccinationByMemberId(int memberId)
        {
            return service.GetVaccinationByMemberId(memberId);
        }

        [HttpPost]
        public IHttpActionResult Post(VaccinationDTO Vaccination)
        {
            try
            {
                var v = service.Post(Vaccination);
                return Created("החיסון התווסף", v);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPut]
        public IHttpActionResult Put(VaccinationDTO Vaccination)
        {
            try
            {
                var v = service.Put(Vaccination);
                return Created("החיסון עודכן", v);
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
                service.Delete(id);
                return Ok("החיסון נמחק");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}