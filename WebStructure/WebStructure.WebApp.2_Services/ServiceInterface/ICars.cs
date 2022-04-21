using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStructure.Common.Models;

namespace WebStructure.WebApp._2_Services.ServiceInterface
{
    public interface ICars
    {
        Task<List<CarModel>> SearchCarsAsync(CarSearchingParameter carSearchingParameter);
        Task<bool> SaveCarSync(CarModel carModel);
        Task<bool> DeleteCarSync(int Id);
        Task<bool> UpdateCarSync(CarModel carModel, int Id);
    }
}
