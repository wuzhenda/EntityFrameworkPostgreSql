using System;
using System.Collections.Generic;

namespace DbFirst.Models
{
    public partial class DeviceInfo
    {
        public string DeviceId { get; set; }
        public string ApiVersion { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string OsName { get; set; }
    }
}
