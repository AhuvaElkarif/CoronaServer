using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Convert
{
    public class CountryConvert
    {
        public static DTO.CountryDTO Convert(DAL.Country obj)
        {
            if (obj == null)
                return null;
            return new DTO.CountryDTO()
            {
                Id = obj.Id,
                Name = obj.Name,
            };
        }

        public static DAL.Country Convert(DTO.CountryDTO obj)
        {
            if (obj == null)
                return null;
            return new DAL.Country()
            {
                Id = obj.Id,
                Name = obj.Name,
            };
        }

        public static List<DAL.Country> Convert(List<DTO.CountryDTO> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        public static List<DTO.CountryDTO> Convert(List<DAL.Country> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
    }
}
