using System;
using System.Collections.Generic;

namespace DbFirst.Models
{
    public partial class KpiVibration
    {
        public long Id { get; set; }
        public string DeviceId { get; set; }
        public short? VibIndex { get; set; }
        public float? ForwardRms { get; set; }
        public float? LateralRms { get; set; }
        public float? VerticalRms { get; set; }
        public float? ForwardAvg { get; set; }
        public float? LateralAvg { get; set; }
        public float? VerticalAvg { get; set; }
        public float? ForwardPeak { get; set; }
        public float? LateralPeak { get; set; }
        public float? VerticalPeak { get; set; }
        public DateTime Ts { get; set; }
    }
}
