using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStructure.Common.Models;
using WebStructure.WebApp._3_BusinessLogic.BusinessLogicInterface;
using WebStructure.WebApp._4_DataAcess.IRepository;

namespace WebStructure.WebApp._3_BusinessLogic.BusinessLogic
{
    public class CarsBusinessLogic :ICarsBusinessLogic

    {
        private readonly ICarsRepository icarsRepository;

        public CarsBusinessLogic(ICarsRepository _icarsRepository)
        {
            icarsRepository = _icarsRepository;
        }

        public async Task<bool> DeleteCarSync(int Id)
        {
            return await icarsRepository.DeleteCarSync(Id);
         
        }

        public async Task<bool> SaveCarSync(CarModel carModel)
        {
            return await icarsRepository.SaveCarSync(carModel);
        }

        public async Task<List<CarModel>> SearchCarsAsync(CarSearchingParameter carSearchingParameter)
        {
            return await icarsRepository.SearchCarsAsync(carSearchingParameter);
        }
        public async Task<bool> UpdateCarSync(CarModel carModel, int Id)
        {
            return await icarsRepository.UpdateCarSync(carModel,Id);
        }
    }
}
