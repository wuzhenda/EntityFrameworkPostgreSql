using System;
using System.Collections.Generic;

namespace DbFirst.Models
{
    public partial class KpiSensor
    {
        public long Id { get; set; }
        public string DeviceId { get; set; }
        public float? DigitalTemp1 { get; set; }
        public float? DigitalTemp2 { get; set; }
        public float? NoiseDbfsRms { get; set; }
        public float? NoiseDbfsAvg { get; set; }
        public float? NoiseDbfsPeak { get; set; }
        public int? PeopleCounter { get; set; }
        public DateTime? Ts { get; set; }
    }
}
