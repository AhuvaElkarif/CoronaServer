using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class CityService
    {
        DAL.Model.CityModel model = new DAL.Model.CityModel();

        public List<DTO.CityDTO> Get()
        {
            return Convert.CityConvert.Convert(model.Get());
        }

        public DTO.CityDTO GetcityBycityId(int cityId)
        {
            return Convert.CityConvert.Convert(model.GetCityByCityId(cityId));
        }

        public DTO.CityDTO Post(CityDTO city)
        {
            return Convert.CityConvert.Convert(model.Post(Convert.CityConvert.Convert(city)));
        }

        public DTO.CityDTO Put(CityDTO city)
        {
            return Convert.CityConvert.Convert(model.Put(Convert.CityConvert.Convert(city)));
        }

        public bool Delete(int city)
        {
            return model.Delete(city);
        }

    }
}

