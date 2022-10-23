using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace API.Controllers
{
    public class CoronaPatientController : ApiController
    {
        BLL.Service.CoronaPatientService service = new BLL.Service.CoronaPatientService();

        [HttpGet]
        [Route("Api/coronaPatient/Get")]
        public List<DTO.CoronaPatientDTO> GetCoronaPatients()
        {
            return service.Get();
        }
        [HttpGet]
        [Route("Api/coronaPatient/GetNumberOfCoronaPatientsInLastMonth")]
        public List<DTO.CoronaPatientsCountDTO> GetNumberOfCoronaPatientsInLastMonth()
        {
            return service.GetNumberOfCoronaPatientsInLastMonth();
        }
        [HttpGet]
        public DTO.CoronaPatientDTO GetCoronaPatientByMemberId(int id)
        {
            return service.GetCoronaPatientByMemberId(id);
        }


        [HttpPost]
        public IHttpActionResult Post(CoronaPatientDTO c)
        {
            try
            {
                var cp = service.Post(c);
                return Created("חולה הקורונה התווסף", cp);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPut]
        public IHttpActionResult Put(CoronaPatientDTO CoronaPatient)
        {
            try
            {
                var cp = service.Put(CoronaPatient);
                return Created("חולה הקורונה עודכן", cp);
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
                var cp = service.Delete(id);
                return Ok("חולה הקורונה נמחק");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}