using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace API.Controllers
{
    public class MemberController : ApiController
    {
        BLL.Service.MemberService service = new BLL.Service.MemberService();

        [HttpGet]
        [Route("Api/member/GetMembers")]
        public List<DTO.MemberDTO> GetMembers()
        {
            return service.Get();
        }
        public DTO.MemberDTO GetMemberByMemberId(int id)
        {
            return service.GetMemberByMemberId(id);
        }


        [HttpPost]
        public IHttpActionResult Post(MemberDTO member)
        {
            try
            {
                var m = service.Post(member);
                return Created("חבר הקופה התווסף", m);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPut]
        [Route("Api/member/updateMember")]
        public IHttpActionResult Put(MemberDTO member)
        {
            try
            {
                var m = service.Put(member);
                return Created("חבר הקופה עודכן", m);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPut]
        //[Route("Api/member/ChangeStatus")]
        public IHttpActionResult ChangeStatus(int id)
        {
            try
            {
                var m = service.ChangeMemberStatus(id);
                return Created("חבר הקופה עודכן", m);
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
                return Ok("חבר הקופה נמחק");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}