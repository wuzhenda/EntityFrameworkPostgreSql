using System;
using System.Collections.Generic;

namespace DbFirst.Models
{
    public partial class RtInfrared
    {
        public long Id { get; set; }
        public string DeviceId { get; set; }
        public short? InfraredIndex { get; set; }
        public float? ObjTemp { get; set; }
        public float? AmbientTemp { get; set; }
        public DateTime Ts { get; set; }
    }
}
