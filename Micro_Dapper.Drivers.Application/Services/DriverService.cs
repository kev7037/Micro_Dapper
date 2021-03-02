using Micro_Dapper.Drivers.Application.Interfaces;
using Micro_Dapper.Drivers.Domain.Interfaces;
using Micro_Dapper.Drivers.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Micro_Dapper.Drivers.Application.Services
{
    public class DriverService : IDriverService
    {
        private readonly IDriverRepository _driverRepository;

        public DriverService(IDriverRepository driverRepository) => _driverRepository = driverRepository;

        public Task<IEnumerable<Driver>> GetAllDrivers() => _driverRepository.GetAllDrivers();
    }
}
