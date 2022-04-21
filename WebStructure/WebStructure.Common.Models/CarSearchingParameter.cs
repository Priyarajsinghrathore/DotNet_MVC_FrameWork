using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStructure.Common.Enums;

namespace WebStructure.Common.Models
{
    public class CarSearchingParameter
    {
        public string? CarName { get; set; }
        public string? ReleaseDate { get; set; }
        public CarType? ColorOfCar { get; set; }
    }
}
