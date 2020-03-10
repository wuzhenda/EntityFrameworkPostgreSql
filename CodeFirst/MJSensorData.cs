using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleApp1
{
    public class MJSensorData
    {
        [Key]
        public int  id { get; set; }

        public string deviceid { get; set; }

        [Required]
        public string kpidata { get; set; }

        
        public String dateTime { get; set; }

        public DateTime vibrationDatas { get; set; }
    }
}
