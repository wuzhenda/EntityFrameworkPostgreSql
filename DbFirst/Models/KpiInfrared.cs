using System;
using System.Collections.Generic;

namespace DbFirst.Models
{
    public partial class KpiInfrared
    {
        public long Id { get; set; }
        public string DeviceId { get; set; }
        public short? InfraredIndex { get; set; }
        public float? ObjTempAvg { get; set; }
        public float? AmbientTempAvg { get; set; }
        public DateTime Ts { get; set; }
    }
}
