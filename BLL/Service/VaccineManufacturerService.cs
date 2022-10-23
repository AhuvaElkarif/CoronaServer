using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class VaccineManufacturerService
    {
        DAL.Model.VaccineManufacturerModel model = new DAL.Model.VaccineManufacturerModel();

        public List<VaccineManufacturerDTO> Get()
        {
            return Convert.VaccineManufacturerConvert.Convert(model.Get());
        }

        public DTO.VaccineManufacturerDTO GetVaccineManufacturerById(int id)
        {
            return Convert.VaccineManufacturerConvert.Convert(model.GetVaccineManufacturerByid(id));
        }

        public DTO.VaccineManufacturerDTO Post(VaccineManufacturerDTO v)
        {
            return Convert.VaccineManufacturerConvert.Convert(model.Post(Convert.VaccineManufacturerConvert.Convert(v)));
        }

        public DTO.VaccineManufacturerDTO Put(VaccineManufacturerDTO v)
        {
            return Convert.VaccineManufacturerConvert.Convert(model.Put(Convert.VaccineManufacturerConvert.Convert(v)));
        }

        public bool Delete(int id)
        {
            return model.Delete(id);
        }

    }
}
