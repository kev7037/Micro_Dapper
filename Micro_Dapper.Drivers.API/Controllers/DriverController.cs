using Micro_Dapper.Drivers.Application.Interfaces;
using Micro_Dapper.Drivers.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Micro_Dapper.Drivers.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        private readonly IDriverService _driverService;

        public DriverController(IDriverService driverService) => _driverService = driverService;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Driver>>> Get() => Ok(await _driverService.GetAllDrivers());

    }
}
