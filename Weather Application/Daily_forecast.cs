using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//"list": [
//        {
//            "dt": 1689508800,
//            "main": {
//                "temp": 303.08,
//                "feels_like": 308.75,
//                "temp_min": 303.08,
//                "temp_max": 303.08,
//                "pressure": 1000,
//                "sea_level": 1000,
//                "grnd_level": 999,
//                "humidity": 73,
//                "temp_kf": 0
//            },
//            "weather": [
//                {
//                    "id": 804,
//                    "main": "Clouds",
//                    "description": "overcast clouds",
//                    "icon": "04d"
//                }
//            ],
//            "clouds": {
//    "all": 98
//            },
//            "wind": {
//    "speed": 5.86,
//                "deg": 170,
//                "gust": 9.09
//            },
//            "visibility": 10000,
//            "pop": 0.79,
//            "sys": {
//    "pod": "d"
//            },
//            "dt_txt": "2023-07-16 12:00:00"
//
//       },

namespace Weather_Application
{
     class Daily_forecast
    {
        public class main
        {
            public double temp { get; set; }
        }

        public class weather
        {
            public string main { get; set; }
            public string icon { get; set; }

        }

        public class list
        {
            public long dt { get; set; }
            public main main { get; set;}
            public List<weather> weather { get; set;}

        }

        public class ForecastInfo
        {
            public List<list>list { get; set;}
        }

    }
}

// "dt": 1689595200,
// "dt": 1689606000,
// "dt": 1689616800,
// "dt": 1689627600,
// "dt": 1689638400,
// "dt": 1689649200,
// "dt": 1689660000,

