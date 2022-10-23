using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class VaccinationDTO
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int VaccinationId { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<int> NumVaccination { get; set; }
        public string VaccinationName { get; set; }
        public string VaccinationCountry { get; set; }


    }
}
