using System;
using System.Collections.Generic;

namespace DbFirst.Models
{
    public partial class MjsensorDatas
    {
        public int Id { get; set; }
        public string Deviceid { get; set; }
        public string Kpidata { get; set; }
        public string DateTime { get; set; }
        public DateTime VibrationDatas { get; set; }
    }
}
