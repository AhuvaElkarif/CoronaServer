using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Convert
{
    public class MemberConvert
    {
        public static DTO.MemberDTO Convert(DAL.Member obj)
        {
            if (obj == null)
                return null;
            return new DTO.MemberDTO()
            {
                Id = obj.Id,
                FirstName = obj.FirstName,
                LastName = obj.LastName,
                BirthDate = obj.BirthDate,
                CityId = obj.CityId,
                HouseNumber = obj.HouseNumber,
                IdNumber = obj.IdNumber,
                IsActive = obj.IsActive,
                Phone = obj.Phone,
                Street = obj.Street,
                Telephone = obj.Telephone,
                CityName = obj.City?.Name
            };
        }

        public static DAL.Member Convert(DTO.MemberDTO obj)
        {
            if (obj == null)
                return null;
            return new DAL.Member()
            {
                Id = obj.Id,
                FirstName = obj.FirstName,
                LastName = obj.LastName,
                BirthDate = obj.BirthDate,
                CityId = obj.CityId,
                HouseNumber = obj.HouseNumber,
                IdNumber = obj.IdNumber,
                IsActive = obj.IsActive,
                Phone = obj.Phone,
                Street = obj.Street,
                Telephone = obj.Telephone,
            };
        }

        public static List<DAL.Member> Convert(List<DTO.MemberDTO> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        public static List<DTO.MemberDTO> Convert(List<DAL.Member> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
    }
}
