using Microsoft.Extensions.Configuration;
using Services.Core.ServiceDiscovery.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Core.ServiceDiscovery.Extensions
{
    public static class ServiceConfigExtensions
    {
        public static ServiceConfig GetServiceConfig(this IConfiguration configuration)
        {
            ArgumentNullException.ThrowIfNull(configuration);

            ServiceConfig serviceConfig = new()
            {
                Id = configuration["ServiceConfig:Id"],
                Name = configuration["ServiceConfig:Name"],
                ApiUrl = configuration["ServiceConfig:ApiUrl"],
                Port = int.Parse(configuration["ServiceConfig:Port"] ?? "0"),
                ConsulUrl = new Uri(configuration["ServiceConfig:ConsulUrl"] ?? "http://localhost"),
                HealthCheckEndPoint = configuration["ServiceConfig:HealthCheckEndPoint"]
            };

            return serviceConfig;
        }
    }
}
