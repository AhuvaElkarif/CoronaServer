using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Convert
{
    public class CoronaPatientConvert
    {
        public static DTO.CoronaPatientDTO Convert(DAL.CoronaPatient obj)
        {
            if (obj == null)
                return null;
            return new DTO.CoronaPatientDTO()
            {
                Id = obj.Id,
                EndDate = obj.EndDate,
                MemberId = obj.MemberId,
                StartDate = obj.StartDate,
            };
        }

        public static DAL.CoronaPatient Convert(DTO.CoronaPatientDTO obj)
        {
            if (obj == null)
                return null;
            return new DAL.CoronaPatient()
            {
                Id = obj.Id,
                EndDate = obj.EndDate,
                MemberId = obj.MemberId,
                StartDate = obj.StartDate,
            };
        }
        public static DTO.CoronaPatientsCountDTO Convert(DAL.CoronaPatientsCount obj)
        {
            if (obj == null)
                return null;
            return new DTO.CoronaPatientsCountDTO()
            {

                x = new DateTime(DateTime.Now.Year, DateTime.Now.Month-1,obj.x),
                y = obj.y
            };
        }

        public static List<DAL.CoronaPatient> Convert(List<DTO.CoronaPatientDTO> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        public static List<DTO.CoronaPatientDTO> Convert(List<DAL.CoronaPatient> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        public static List<DTO.CoronaPatientsCountDTO> Convert(List<DAL.CoronaPatientsCount> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
    }
}
