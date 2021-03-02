using Micro_Dapper.Drivers.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Micro_Dapper.Drivers.Domain.Interfaces
{
    public interface IDriverRepository
    {
        Task<IEnumerable<Driver>> GetAllDrivers();
        IEnumerable<Driver> GetDriverByParam(Driver driver);

    }
}
