using System.Collections.Generic;
using Core.Models;

namespace DataAccess
{
    public class StaticDataAccess : IDataAccess
    {
        private static readonly List<Vehicle> Vehicles =
            new List<Vehicle> {new Vehicle("Saab", "9-3", 2003), new Vehicle("Vovlo", "V60", 2014)};

        public IList<Vehicle> GetAllVehicles()
        {
            return Vehicles;
        }
    }
}