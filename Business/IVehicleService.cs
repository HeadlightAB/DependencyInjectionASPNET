using System.Collections.Generic;
using Core.Models;

namespace Business
{
    public interface IVehicleService
    {
        IList<Vehicle> GetAll();
    }
}