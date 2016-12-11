using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABBhack.Models
{
    class Device
    {
        public int ID { get; set; }
        public double Longtitude { get; set; }
        public double Latitude { get; set; }
        public float Humidity { get; set; }
        public float Temperature { get; set; }
        public float Light { get; set; }
    }
}
