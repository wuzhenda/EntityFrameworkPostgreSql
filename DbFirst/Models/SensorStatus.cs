using System;
using System.Collections.Generic;

namespace DbFirst.Models
{
    public partial class SensorStatus
    {
        public long Id { get; set; }
        public int? Vibration1 { get; set; }
        public int? Vibration2 { get; set; }
        public int? Vibration3 { get; set; }
        public int? Vibration4 { get; set; }
        public int? Vibration5 { get; set; }
        public int? Vibration6 { get; set; }
        public int? Vibration7 { get; set; }
        public int? Vibration8 { get; set; }
        public int? Vibration9 { get; set; }
        public int? Vibration10 { get; set; }
        public int? Infrared1 { get; set; }
        public int? Infrared2 { get; set; }
        public int? DigitalTemp1 { get; set; }
        public int? DigitalTemp2 { get; set; }
        public int? Noise { get; set; }
        public int? Power { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
