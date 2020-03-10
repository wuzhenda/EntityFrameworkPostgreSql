using System;
using System.Collections.Generic;

namespace DbFirst.Models
{
    public partial class RtVibration
    {
        public long Id { get; set; }
        public string DeviceId { get; set; }
        public short? VibIndex { get; set; }
        public float? Forward { get; set; }
        public float? Lateral { get; set; }
        public float? Vertical { get; set; }
        public DateTime Ts { get; set; }
    }
}
