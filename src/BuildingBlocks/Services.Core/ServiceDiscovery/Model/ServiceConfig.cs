using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Core.ServiceDiscovery.Model
{
    public class ServiceConfig
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string ApiUrl { get; set; }

        public int Port { get; set; }

        public Uri ConsulUrl { get; set; }

        public string HealthCheckEndPoint { get; set; }
    }
}
