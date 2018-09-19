using System.Collections.Generic;
using Core.Models;

namespace DataAccess
{
    public interface IDataAccess
    {
        IList<Vehicle> GetAllVehicles();
    }
}
