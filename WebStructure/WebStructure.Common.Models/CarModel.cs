using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStructure.Common.Enums;

namespace WebStructure.Common.Models
{
    public class CarModel
    {
        public int? Id { get; set; }
        public string? CarName { get; set; }
        public string? Carmodel { get; set; }

        public string? CarManufacturer { get; set; }
        public CarType? CarColor { get; set; }
        public string? CarReleaseDate { get; set; }

    }
}
