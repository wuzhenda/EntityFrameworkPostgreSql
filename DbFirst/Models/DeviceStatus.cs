using System;
using System.Collections.Generic;

namespace DbFirst.Models
{
    public partial class DeviceStatus
    {
        public long Id { get; set; }
        public string DeviceId { get; set; }
        public string Manufacturer { get; set; }
        public string HdVersion { get; set; }
        public string SwVersion { get; set; }
        public string Model { get; set; }
        public int? Version { get; set; }
        public int? Capacity { get; set; }
        public DateTime? Ts { get; set; }
    }
}
