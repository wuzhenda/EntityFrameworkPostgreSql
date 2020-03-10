using System;
using System.Collections.Generic;

namespace DbFirst.Models
{
    public partial class Readings
    {
        public DateTime Time { get; set; }
        public string DeviceId { get; set; }
        public double? BatteryLevel { get; set; }
        public string BatteryStatus { get; set; }
        public double? BatteryTemperature { get; set; }
        public string Bssid { get; set; }
        public double? CpuAvg1min { get; set; }
        public double? CpuAvg5min { get; set; }
        public double? CpuAvg15min { get; set; }
        public double? MemFree { get; set; }
        public double? MemUsed { get; set; }
        public double? Rssi { get; set; }
        public string Ssid { get; set; }
    }
}
