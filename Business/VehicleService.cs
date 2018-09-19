using System.Collections.Generic;
using Core.Models;
using DataAccess;

namespace Business
{
    public class VehicleService : IVehicleService
    {
        private readonly IDataAccess _dataAccess;

        public VehicleService(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public IList<Vehicle> GetAll()
        {
            return _dataAccess.GetAllVehicles();
        }
    }
}
