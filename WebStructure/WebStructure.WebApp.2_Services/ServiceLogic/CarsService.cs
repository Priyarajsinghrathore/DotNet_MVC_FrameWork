using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStructure.Common.Models;
using WebStructure.WebApp._2_Services.ServiceInterface;
using WebStructure.WebApp._3_BusinessLogic.BusinessLogicInterface;

namespace WebStructure.WebApp._2_Services.ServiceLogic
{
    public class CarsService : ICars
    {
        private readonly ICarsBusinessLogic icarsBusinessLogic;

        public CarsService(ICarsBusinessLogic _icarsBusinessLogic)
        {
            icarsBusinessLogic = _icarsBusinessLogic;
        }

        public async Task<List<CarModel>> SearchCarsAsync(CarSearchingParameter carSearchingParameter)
        {
            return await icarsBusinessLogic.SearchCarsAsync(carSearchingParameter);
        }

        public async Task<bool> SaveCarSync(CarModel carModel)
        {
            return await icarsBusinessLogic.SaveCarSync(carModel);
        }

        public async Task<bool> DeleteCarSync(int Id)
        {
            return await icarsBusinessLogic.DeleteCarSync(Id);
        }

      

        public async Task<bool>UpdateCarSync(CarModel carModel, int Id)
        {
            return await icarsBusinessLogic.UpdateCarSync(carModel,Id);
        }
    }
}
