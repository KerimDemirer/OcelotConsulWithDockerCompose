using Consul;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Services.Core.ServiceDiscovery.Model;
using Services.Core.ServiceDiscovery.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Core.ServiceDiscovery.Extensions
{
    public static class ServiceDiscoveryExtensions
    {
        public static void AddConsul(this IServiceCollection services, ServiceConfig serviceConfig)
        {
            ArgumentNullException.ThrowIfNull(serviceConfig);

            var consulClient = new ConsulClient(config =>
            {
                config.Address = serviceConfig.ConsulUrl;
            });

            services.AddSingleton(serviceConfig);
            services.AddSingleton<IConsulClient, ConsulClient>(provider => consulClient);
            services.AddSingleton<IHostedService, ServiceDiscoveryHostedService>();
        }
    }
}
