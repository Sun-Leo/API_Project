﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DTOLayer.DTOS.AppUserWithLocation
{
    public class AppUserWithLocation
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string ImageUrl { get; set; }
        public string Status { get; set; }
        public string Department { get; set; }
        public string WorkLocationName { get; set; }
        public int WorkLocationID { get; set; }
    }
}
