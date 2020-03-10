using System;
using System.Collections.Generic;

namespace DbFirst.Models
{
    public partial class RtPower
    {
        public long Id { get; set; }
        public string DeviceId { get; set; }
        public float? VoltageA { get; set; }
        public float? VoltageB { get; set; }
        public float? VoltageC { get; set; }
        public float? CurrentA { get; set; }
        public float? CurrentB { get; set; }
        public float? CurrentC { get; set; }
        public float? ActivePowerA { get; set; }
        public float? ActivePowerB { get; set; }
        public float? ActivePowerC { get; set; }
        public float? ActivePowerTotal { get; set; }
        public float? ReactivePowerTotal { get; set; }
        public float? ApparentPowerTotal { get; set; }
        public float? PowerFactorTotal { get; set; }
        public float? PowerConsumptionTotal { get; set; }
        public DateTime? Ts { get; set; }
    }
}
