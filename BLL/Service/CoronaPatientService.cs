using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class CoronaPatientService
    {
        DAL.Model.CoronaPatientModel model = new DAL.Model.CoronaPatientModel();

        public List<DTO.CoronaPatientDTO> Get()
        {
            return Convert.CoronaPatientConvert.Convert(model.Get());
        }
        public List<DTO.CoronaPatientsCountDTO> GetNumberOfCoronaPatientsInLastMonth()
        {
            return Convert.CoronaPatientConvert.Convert(model.GetNumberOfCoronaPatientsInLastMonth());
        }

        public DTO.CoronaPatientDTO GetCoronaPatientByMemberId(int id)
        {
            return Convert.CoronaPatientConvert.Convert(model.GetCoronaPatientByMemberId(id));
        }

        public DTO.CoronaPatientDTO Post(CoronaPatientDTO coronaPatient)
        {
            return Convert.CoronaPatientConvert.Convert(model.Post(Convert.CoronaPatientConvert.Convert(coronaPatient)));
        }

        public DTO.CoronaPatientDTO Put(CoronaPatientDTO coronaPatient)
        {
            return Convert.CoronaPatientConvert.Convert(model.Put(Convert.CoronaPatientConvert.Convert(coronaPatient)));
        }

        public bool Delete(int coronaPatient)
        {
            return model.Delete(coronaPatient);
        }

    }
}

