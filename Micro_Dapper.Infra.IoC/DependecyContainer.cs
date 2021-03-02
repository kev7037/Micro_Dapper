using Micro_Dapper.Domain.Core.Bus;
using Micro_Dapper.Drivers.Application.Interfaces;
using Micro_Dapper.Drivers.Application.Services;
using Micro_Dapper.Drivers.Data.Repository;
using Micro_Dapper.Drivers.Domain.Interfaces;
using Micro_Dapper.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Micro_Dapper.Infra.IoC
{
    public class DependecyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain Bus
            services.AddTransient<IEventBus, RabbitMQBus>();

            //Application Services
            services.AddTransient<IDriverService, DriverService>();

            //Data
            services.AddTransient<IDriverRepository, DriverRepository>();
        }
    }
}
