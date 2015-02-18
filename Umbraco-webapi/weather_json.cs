using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using umbraco.cms.helpers;

namespace Umbraco_webapi
{
    public class weather_json
    {
        [DataContract]
        public class Rootobject
        {
            [DataMember]
            public string cod { get; set; }
            [DataMember]
            public float message { get; set; }
            [DataMember]
            public City city { get; set; }
            [DataMember]
            public int cnt { get; set; }
            [DataMember]
            public List<List> list { get; set; }
        }
        
        public class City
        {
            public int id { get; set; }
            public string name { get; set; }
            public Coord coord { get; set; }           
            public string country { get; set; }
            public int population { get; set; }
            public Sys sys { get; set; }
        }

        public class Coord
        {
            public float lon { get; set; }
            public float lat { get; set; }
        }

        public class Sys
        {
            public int population { get; set; }
        }

        public class List
        {
            public int dt { get; set; }
            public Temp temp { get; set; }
            public float pressure { get; set; }
            public int humidity { get; set; }
            public Weather[] weather { get; set; }
            public float speed { get; set; }
            public int deg { get; set; }
            public int clouds { get; set; }
            public float rain { get; set; }
        }

        public class Temp
        {
            public float day { get; set; }
            public float min { get; set; }
            public float max { get; set; }
            public float night { get; set; }
            public float eve { get; set; }
            public float morn { get; set; }
        }

        public class Weather
        {
            public int id { get; set; }
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }
        }
    }
}