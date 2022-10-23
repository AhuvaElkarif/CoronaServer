using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Convert
{
    public class VaccineManufacturerConvert
    {
        public static DTO.VaccineManufacturerDTO Convert(DAL.VaccineManufacturer obj)
        {
            if (obj == null)
                return null;
            return new DTO.VaccineManufacturerDTO()
            {
                Id = obj.Id,
                Name = obj.Name,
                CountryId = obj.CountryId,
            };
        }

        public static DAL.VaccineManufacturer Convert(DTO.VaccineManufacturerDTO obj)
        {
            if (obj == null)
                return null;
            return new DAL.VaccineManufacturer()
            {
                Id = obj.Id,
                Name = obj.Name,
                CountryId = obj.CountryId,
            };
        }

        public static List<DAL.VaccineManufacturer> Convert(List<DTO.VaccineManufacturerDTO> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        public static List<DTO.VaccineManufacturerDTO> Convert(List<DAL.VaccineManufacturer> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
    }
}

