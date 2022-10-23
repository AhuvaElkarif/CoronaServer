using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Convert
{
    public class CityConvert
    {
        public static DTO.CityDTO Convert(DAL.City obj)
        {
            if (obj == null)
                return null;
            return new DTO.CityDTO()
            {
                Id = obj.Id,
                Name = obj.Name,
            };
        }

        public static DAL.City Convert(DTO.CityDTO obj)
        {
            if (obj == null)
                return null;
            return new DAL.City()
            {
                Id = obj.Id,
                Name = obj.Name,
            };
        }

        public static List<DAL.City> Convert(List<DTO.CityDTO> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        public static List<DTO.CityDTO> Convert(List<DAL.City> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
    }
}
