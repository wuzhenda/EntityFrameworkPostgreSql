using System;
using System.Collections.Generic;

namespace DbFirst.Models
{
    public partial class EscalatorStatus
    {
        public long Id { get; set; }
        public bool? IsAuto { get; set; }
        public bool? IsRunning { get; set; }
        public bool? IsUpRunning { get; set; }
        public bool? IsDownRunning { get; set; }
        public bool? IsSuspend { get; set; }
        public bool? IsFaultStop { get; set; }
        public bool? IsSafetyLoopOn { get; set; }
        public bool? IsEmergencyStop { get; set; }
        public bool? IsUpperCoverOpen { get; set; }
        public bool? IsLowerCoverOpen { get; set; }
        public bool? IsNormalStop { get; set; }
        public bool? IsFireControl { get; set; }
        public bool? IsBreakOn { get; set; }
        public bool? IsFault { get; set; }
        public int? Speed { get; set; }
        public int? HandrailSpeed { get; set; }
        public int? StepMissingMeasurementSpeed { get; set; }
        public int? Power { get; set; }
        public int? Loadrate { get; set; }
        public int? BusbarVoltage { get; set; }
        public int? Current { get; set; }
        public int? BrakingDistance { get; set; }
        public int? OriginalFaultCode { get; set; }
        public float? TotalOperationTime { get; set; }
        public float? HighSpeedOperationTime { get; set; }
        public float? LowSpeedOperationTime { get; set; }
        public DateTime DateTime { get; set; }
    }
}
