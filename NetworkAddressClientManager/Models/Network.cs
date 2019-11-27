using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using Microsoft.AspNetCore.HttpOverrides;

namespace NetworkAddressClientManager.Models
{
    public class Network
    {
        public long Id { get; set; }
        public IPNetwork IpNetwork { get; set; }
    }
}
