﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class VaccineManufacturerDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> CountryId { get; set; }
    }
}
