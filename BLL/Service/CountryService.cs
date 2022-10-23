using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class CountryService
    {
        DAL.Model.CountryModel model = new DAL.Model.CountryModel();

        public List<DTO.CountryDTO> Get()
        {
            return Convert.CountryConvert.Convert(model.Get());
        }

        public DTO.CountryDTO GetCountryByCountryId(int countryId)
        {
            return Convert.CountryConvert.Convert(model.GetCountryBycountryId(countryId));
        }

        public DTO.CountryDTO Post(CountryDTO country)
        {
            return Convert.CountryConvert.Convert(model.Post(Convert.CountryConvert.Convert(country)));
        }

        public DTO.CountryDTO Put(CountryDTO country)
        {
            return Convert.CountryConvert.Convert(model.Put(Convert.CountryConvert.Convert(country)));
        }

        public bool Delete(int country)
        {
            return model.Delete(country);
        }

    }
}
