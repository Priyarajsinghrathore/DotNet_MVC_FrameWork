using Microsoft.EntityFrameworkCore;
using Polly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStructure.Common.Enums;
using WebStructure.Common.Models;
using WebStructure.WebApp._4_DataAcess.Entity;
using WebStructure.WebApp._4_DataAcess.IRepository;

namespace WebStructure.WebApp._4_DataAcess.Repository
{
    public class CarsRepository:BaseRepository,ICarsRepository

    {
        public CarsRepository(Context _context) : base(_context) { }

        public async Task<List<CarModel>> SearchCarsAsync(CarSearchingParameter carSearchingParameter)
        {
           // IQueryable<CarEntity>? CarQuery = (IQueryable<CarEntity>)_context.CarDbSet.OrderBy(m => m.CarName);
            IQueryable<CarEntity>? CarQuery = (IQueryable<CarEntity>)_context.CarDbSet.AsQueryable();

            return await CarQuery.Select(m => new CarModel
            {
                Id = m.Id,
                CarName = m.CarName,
                Carmodel = m.CarModel,
                CarManufacturer = m.CarManufacturer,
                CarColor = (CarType?)(short?)m.CarColor,
                CarReleaseDate = m.CarReleaseDate
            }
            ).ToListAsync();


        }
        //For Save Records
        public async Task<bool> SaveCarSync(CarModel carModel)
        {
            var CarObj = _context.CarDbSet.Find(carModel.Id);
            if(CarObj == null)
            {
                CarObj = new CarEntity();
                _context.Add(CarObj);
            }         

            
            CarObj.CarName = carModel.CarName;
            CarObj.CarModel= carModel.Carmodel;
            CarObj.CarManufacturer = carModel.CarManufacturer;
            CarObj.CarColor = (short)carModel.CarColor;
            CarObj.CarReleaseDate = carModel.CarReleaseDate;
            return await _context.SaveChangesAsync() > 0;
           
        }
        //Delete Records
        public async Task<bool> DeleteCarSync(int Id)
        {

            CarEntity carDel = new CarEntity() {Id = Id };

            _context.Remove(carDel);

            return await _context.SaveChangesAsync() > 0;
            
        }
        //Update Records
        public async Task<bool> UpdateCarSync(CarModel carModel, int Id)
        {
            var carObj = new CarEntity()
            {
                Id = Id,
                CarColor = (short?)carModel.CarColor,
                CarName = carModel.CarName,
                CarModel = carModel.Carmodel,
                CarManufacturer = carModel.CarManufacturer,
                CarReleaseDate = carModel.CarReleaseDate
            };
  
            _context.Update(carObj);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}   
