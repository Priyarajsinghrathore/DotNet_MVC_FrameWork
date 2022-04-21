using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStructure.Common.Models;

namespace WebStructure.WebApp._3_BusinessLogic.BusinessLogicInterface
{
    public interface ICarsBusinessLogic
    {
        Task<List<CarModel>> SearchCarsAsync(CarSearchingParameter carSearchingParameter);

        Task<bool> SaveCarSync(CarModel carModel);

        Task<bool> DeleteCarSync(int Id);
        Task<bool> UpdateCarSync(CarModel carModel, int Id);

    }
}
