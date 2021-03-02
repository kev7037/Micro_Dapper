using Micro_Dapper.Domain.Core.Bus;
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
        }
    }
}
