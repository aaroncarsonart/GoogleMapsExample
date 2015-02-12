using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MapsExample2.Models
{
    public class Location
    {
        public int ID { get; set; }
        public string Label { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
    }
}