using Micro_Dapper.Drivers.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Micro_Dapper.Drivers.Application.Interfaces
{
    public interface IDriverService
    {
        Task<IEnumerable<Driver>> GetAllDrivers();
    }
}
