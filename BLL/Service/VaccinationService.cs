using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class VaccinationService
    {
        DAL.Model.VaccinationModel model = new DAL.Model.VaccinationModel();

        public List<DTO.VaccinationDTO> Get()
        {
            return Convert.VaccinationConvert.Convert(model.Get());
        }

        public DTO.VaccinationDTO GetVaccinationByvaccinationId(int vaccinationId)
        {
            return Convert.VaccinationConvert.Convert(model.GetVaccinationByvaccinationId(vaccinationId));
        }
        public List<DTO.VaccinationDTO> GetVaccinationByMemberId(int memberId)
        {
            return Convert.VaccinationConvert.Convert(model.GetVaccinationByMemberId(memberId));
        }

        public DTO.VaccinationDTO Post(VaccinationDTO vaccination)
        {
            return Convert.VaccinationConvert.Convert(model.Post(Convert.VaccinationConvert.Convert(vaccination)));
        }

        public DTO.VaccinationDTO Put(VaccinationDTO vaccination)
        {
            return Convert.VaccinationConvert.Convert(model.Put(Convert.VaccinationConvert.Convert(vaccination)));
        }

        public bool Delete(int vaccination)
        {
            return model.Delete(vaccination);
        }

    }
}
