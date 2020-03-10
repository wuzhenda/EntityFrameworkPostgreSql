using System;
using System.Collections.Generic;

namespace DbFirst.Models
{
    public partial class KpiPower
    {
        public long Id { get; set; }
        public string DeviceId { get; set; }
        public float? CurrentAAvg { get; set; }
        public float? CurrentBAvg { get; set; }
        public float? CurrentCAvg { get; set; }
        public float? ActivePowerAAvg { get; set; }
        public float? ActivePowerBAvg { get; set; }
        public float? ActivePowerCAvg { get; set; }
        public float? ActivePowerTotalAvg { get; set; }
        public float? ReactivePowerTotalAvg { get; set; }
        public float? ApparentPowerTotalAvg { get; set; }
        public float? PowerFactorTotalAvg { get; set; }
        public float? CurrentAPeak { get; set; }
        public float? CurrentBPeak { get; set; }
        public float? CurrentCPeak { get; set; }
        public float? ActivePowerAPeak { get; set; }
        public float? ActivePowerBPeak { get; set; }
        public float? ActivePowerCPeak { get; set; }
        public float? ActivePowerTotalPeak { get; set; }
        public float? ReactivePowerTotalPeak { get; set; }
        public float? ApparentPowerTotalPeak { get; set; }
        public DateTime? Ts { get; set; }
    }
}
