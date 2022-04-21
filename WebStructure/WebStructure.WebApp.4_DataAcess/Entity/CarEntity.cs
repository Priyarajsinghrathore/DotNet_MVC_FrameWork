﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebStructure.WebApp._4_DataAcess.Entity
{
    public class CarEntity
    {
        public int? Id { get; set; }
        public string? CarName { get; set; }
        public string? CarModel { get; set; }
        public string? CarReleaseDate { get; set; }
        public short? CarColor { get; set; }

        public string? CarManufacturer { get; set; }
    }
}
