﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeMeshNetwork.Models
{
    public class SensorModel
    {
        public int Temperature { get; set; }
        public int Humidity { get; set; }
        public bool FireAlarm { get; set; }
        public bool WaterAlarm { get; set; }
    }
}