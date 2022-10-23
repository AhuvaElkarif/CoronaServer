using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class MemberService
    {

        DAL.Model.MemberModel model = new DAL.Model.MemberModel();

        public List<DTO.MemberDTO> Get()
        {
            return Convert.MemberConvert.Convert(model.Get());
        }

        public DTO.MemberDTO GetMemberByMemberId(int memberId)
        {
            return Convert.MemberConvert.Convert(model.GetMemberByMemberId(memberId));
        }

        public DTO.MemberDTO Post(MemberDTO member)
        {
            return Convert.MemberConvert.Convert(model.Post(Convert.MemberConvert.Convert(member)));
        }
        
        public DTO.MemberDTO Put(MemberDTO member)
        {
            return Convert.MemberConvert.Convert(model.Put(Convert.MemberConvert.Convert(member)));
        }
        public DTO.MemberDTO ChangeMemberStatus(int id)
        {
            return Convert.MemberConvert.Convert(model.ChangeMemberStatus(id));
        }
        public bool Delete(int member)
        {
            return model.Delete(member);
        }

    }
}
