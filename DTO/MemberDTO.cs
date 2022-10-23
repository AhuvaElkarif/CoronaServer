using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MemberDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdNumber { get; set; }
        public int CityId { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public System.DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string Telephone { get; set; }

        public string CityName { get; set; }

    }
}
