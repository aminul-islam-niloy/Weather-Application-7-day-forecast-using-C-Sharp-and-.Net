using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Application
{
    class WeatherInfo
    {

        //      "coord": {
        //    "lon": 89.5672,
        //    "lat": 22.8135
        //}


        public class coord
        {
          public  double lon { get; set; }
          public double lat { get; set; }
        }

        //    "weather": [
        //    {
        //        "id": 803,
        //        "main": "Clouds",
        //        "description": "broken clouds",
        //        "icon": "04n"
        //    }
        //]
        public class weather
        {
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }

        }

        //    "main": {
        //    "temp": 301.79,
        //    "feels_like": 307.3,
        //    "temp_min": 301.79,
        //    "temp_max": 301.79,
        //    "pressure": 1003,
        //    "humidity": 82,
        //    "sea_level": 1003,
        //    "grnd_level": 1002
        //},

        public class main
        {
            public double temp { get; set; }
            public double feels_like { get; set; }
            public double temp_min { get; set; }
            public double temp_max { get; set; }
            public double pressure { get; set; }
            public double humidity { get; set; }

        }
        // "visibility": 10000,

        //    "wind": {
        //    "speed": 4.15,
        //    "deg": 183,
        //    "gust": 7.26
        //},
        //"clouds": {
        //    "all": 74
        //},

        public class wind
        {
            public double speed { get; set; }

        }

        public class clouds
        {
            public double all { get; set; }


        }

        //    "sys": {
        //    "country": "BD",
        //    "sunrise": 1689290682,
        //    "sunset": 1689338995
        //},

        public class sys
        {
            public string country { get; set; }
            public long sunrise { get; set; }
            public long sunset { get; set; }

        }
       


        public class root
        {
            public coord coord { get; set; }
            public List<weather> weather { get; set; }
            public main main { get; set; }
            public wind wind { get; set; }
            public clouds clouds { get; set; }
            public sys sys { get; set; }
           
           
        }
        public string name { get; set; }
        public string dt { get; set; }



    }
}
