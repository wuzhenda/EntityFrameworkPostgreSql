using System;
using System.Collections.Generic;

namespace DbFirst.Models
{
    public partial class SensorConfig
    {
        public long Id { get; set; }
        public int? KpiInterval { get; set; }
        public int? Reserved { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
